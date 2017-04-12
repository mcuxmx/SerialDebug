using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Collections;

namespace XMX.FileTransmit
{

    public enum XModemCheckMode
    {
        CheckSum,
        CRC16
    }

    public enum XModemType
    {
        XModem,
        XModem_1K
    }

    /// <summary>
    /// XModem接收到的消息类型
    /// </summary>
    enum XmodemMessageType : int
    {
        KEY_C,
        ACK,
        NAK,
        EOT,
        PACKET,
        PACKET_ERROR,
        CAN
    }

    /// <summary>
    /// XModem接收到的消息内容
    /// </summary>
    internal class XmodemMessage
    {
        private XmodemMessageType _MessageType;
        private object _Value;


        public XmodemMessage(XmodemMessageType type)
            : this(type, null)
        {

        }

        public XmodemMessage(XmodemMessageType type, object value)
        {
            _MessageType = type;
            _Value = value;
        }


        public XmodemMessageType MessageType
        {
            get { return _MessageType; }
        }

        public object Value
        {
            get { return _Value; }
        }
    }

    /// <summary>
    /// Xmodem发送步骤
    /// </summary>
    internal enum XmodemSendStage : int
    {
        WaitReceiveRequest,   //等待接收端请求
        PacketSending,
        WaitReceiveAnswerEndTransmit
    }

    /// <summary>
    /// Xmodem接收步骤
    /// </summary>
    internal enum XmodemReceiveStage : int
    {
        WaitForFirstPacket,
        PacketReceiving,
    }

    public class XModemInfo
    {
        private XModemType _XModemType;
        private TransmitMode _TransType;
        private XModemCheckMode _CheckMode;

        public XModemInfo()
            : this(XModemType.XModem, TransmitMode.Send, XModemCheckMode.CheckSum)
        {

        }

        public XModemInfo(XModemType type, TransmitMode transType, XModemCheckMode checkType)
        {
            _XModemType = type;
            _TransType = transType;
            _CheckMode = checkType;
        }


        public XModemType Type
        {
            get { return _XModemType; }
            set { _XModemType = value; }
        }

        public TransmitMode TransMode
        {
            get { return _TransType; }
            set { _TransType = value; }
        }

        public XModemCheckMode CheckMode
        {
            get { return _CheckMode; }
            set { _CheckMode = value; }
        }

    }

    public class XModem : IFileTramsmit, ITransmitUart
    {
        private readonly byte SOH = 0x01;
        private readonly byte EOT = 0x04;
        private readonly byte ACK = 0x06;
        private readonly byte NAK = 0x15;
        private readonly byte CAN = 0x18;

        private readonly byte STX = 0x02;
        private readonly byte KEY_C = 0x43; //'C';

        private int RetryMax = 6;
        XModemInfo xmodemInfo = new XModemInfo();


        private Thread TransThread;
        private bool IsStart = false;
        private int reTryCount;
        private ManualResetEvent waitReceiveEvent = new ManualResetEvent(false);


        private XmodemReceiveStage ReceiveStage;
        private XmodemSendStage SendStage;
        private Queue<XmodemMessage> msgQueue = new Queue<XmodemMessage>();

        public XModem(TransmitMode transType, XModemType xmodemType, int reTryCount)
        {
            RetryMax = reTryCount;

            xmodemInfo.CheckMode = XModemCheckMode.CheckSum;
            xmodemInfo.Type = xmodemType;
            xmodemInfo.TransMode = transType;
        }

        public void Start()
        {
            IsStart = true;
            reTryCount = 0;


            ReceiveStage = XmodemReceiveStage.WaitForFirstPacket;
            SendStage = XmodemSendStage.WaitReceiveRequest;
            msgQueue.Clear();

            TransThread = new Thread(new ThreadStart(TransThreadHandler));
            TransThread.IsBackground = true;
            TransThread.Name = "XmodemTransThread";
            TransThread.Start();
            if (xmodemInfo.TransMode == TransmitMode.Receive)
            {
                if (StartReceive != null)
                {
                    StartReceive(xmodemInfo, null);
                }
            }
        }

        public void Stop()
        {
            if (xmodemInfo.TransMode == TransmitMode.Receive)
            {
                Abort();
            }
            else
            {
                SendEOT();
            }

            if (EndOfTransmit != null)
            {
                EndOfTransmit(xmodemInfo, null);
            }
        }

        public void Abort()
        {
            IsStart = false;
            SendCAN();

            if (EndOfTransmit != null)
            {
                EndOfTransmit(xmodemInfo, null);
            }
        }


        /// <summary>
        /// 解析数据
        /// </summary>
        /// <param name="data"></param>
        private void ParseReceivedMessage(byte[] data)
        {
            XmodemMessage ReceivedMessage = null;

            if (data == null)
            {
                ReceivedMessage = null;
            }
            else
            {
                if (data[0] == STX || data[0] == SOH)
                {
                    ReceivedMessage = new XmodemMessage(XmodemMessageType.PACKET_ERROR);
                    int packetLen = 0;
                    if (data[0] == STX)
                    {
                        packetLen = 1024;
                    }
                    else if (data[0] == SOH)
                    {
                        packetLen = 128;
                    }

                    int checkDataLen = xmodemInfo.CheckMode == XModemCheckMode.CheckSum ? 1 : 2;
                    if (packetLen + 3 + checkDataLen == data.Length)
                    {
                        int packetNo = 0;
                        if (data[1] == Convert.ToByte((~data[2]) & 0xFF))
                        {
                            packetNo = data[1];
                        }

                        int frameCheckCode = 0;
                        int calCheckCode = -1;
                        byte[] packet = new byte[packetLen];

                        Array.Copy(data, 3, packet, 0, packetLen);
                        if (xmodemInfo.CheckMode == XModemCheckMode.CheckSum)
                        {
                            frameCheckCode = data[3 + packetLen];
                            calCheckCode = Convert.ToByte(DataCheck.GetCheckSum(packet) & 0xFF);
                        }
                        else
                        {
                            frameCheckCode = (data[3 + packetLen] << 8) + data[3 + packetLen + 1];
                            calCheckCode = Convert.ToUInt16(DataCheck.GetCRC(CRCType.CRC16_XMODEM, packet) & 0xFFFF);
                        }

                        if (frameCheckCode == calCheckCode)
                        {
                            ReceivedMessage = new XmodemMessage(XmodemMessageType.PACKET, new PacketEventArgs(packetNo, packet));
                        }

                    }
                    msgQueue.Enqueue(ReceivedMessage);
                }
                else
                {
                    foreach (byte b in data)
                    {
                        ReceivedMessage = null;
                        if (b == EOT)
                        {
                            ReceivedMessage = new XmodemMessage(XmodemMessageType.EOT);
                        }
                        else if (b == CAN)
                        {
                            ReceivedMessage = new XmodemMessage(XmodemMessageType.CAN);
                        }
                        else if (b == NAK)
                        {
                            ReceivedMessage = new XmodemMessage(XmodemMessageType.NAK);
                        }
                        else if (b == ACK)
                        {
                            ReceivedMessage = new XmodemMessage(XmodemMessageType.ACK);
                        }
                        else if (b == KEY_C)
                        {
                            ReceivedMessage = new XmodemMessage(XmodemMessageType.KEY_C);
                        }

                        if (ReceivedMessage != null)
                        {
                            msgQueue.Enqueue(ReceivedMessage);
                        }
                    }
                }

            }

            waitReceiveEvent.Set();

        }


        private void SendFrameToUart(byte data)
        {
            byte[] bytes = new byte[1];
            bytes[0] = data;
            SendFrameToUart(bytes);
        }
        private void SendFrameToUart(byte[] data)
        {
            if (SendToUartEvent != null)
            {
                SendToUartEvent(xmodemInfo, new SendToUartEventArgs(data));
            }
        }

        private void SendACK()
        {
            SendFrameToUart(ACK);

        }

        private void SendNAK()
        {
            SendFrameToUart(NAK);
        }

        private void SendKEYC()
        {
            SendFrameToUart(KEY_C);
        }

        private void SendCAN()
        {
            byte[] bytes = new byte[5];
            for (int i = 0; i < 5; i++)
            {
                bytes[i] = CAN;
            }
            SendFrameToUart(bytes);
        }

        private void SendEOT()
        {
            SendFrameToUart(EOT);
            SendStage = XmodemSendStage.WaitReceiveAnswerEndTransmit;
        }




        void TransThreadHandler()
        {
            while (IsStart)
            {
                if (xmodemInfo.TransMode == TransmitMode.Send)
                {
                    SendHandler();
                }
                else if (xmodemInfo.TransMode == TransmitMode.Receive)
                {
                    ReceiveHandler();
                }
            }
        }

        void SendHandler()
        {
            XmodemMessage msg = null;
            lock (msgQueue)
            {
                if (msgQueue.Count > 0)
                {
                    msg = msgQueue.Dequeue();
                }
            }

            if (msg != null)
            {
                reTryCount = 0;

                switch (msg.MessageType)
                {
                    case XmodemMessageType.NAK:
                        if (SendStage == XmodemSendStage.WaitReceiveRequest)
                        {
                            SendStage = XmodemSendStage.PacketSending;

                            xmodemInfo.CheckMode = XModemCheckMode.CheckSum;
                            if (StartSend != null)
                            {
                                StartSend(xmodemInfo, null);
                            }
                        }
                        else if (SendStage == XmodemSendStage.WaitReceiveAnswerEndTransmit)
                        {
                            SendEOT();
                        }
                        else
                        {
                            // 通知重发或发头一包
                            if (ReSendPacket != null)
                            {
                                ReSendPacket(xmodemInfo, null);
                            }
                        }
                        break;

                    case XmodemMessageType.KEY_C:
                        if (SendStage == XmodemSendStage.WaitReceiveRequest)
                        {
                            SendStage = XmodemSendStage.PacketSending;
                            // 通知发头一包CRC
                            xmodemInfo.CheckMode = XModemCheckMode.CRC16;
                            if (StartSend != null)
                            {
                                StartSend(xmodemInfo, null);
                            }
                        }
                        break;

                    case XmodemMessageType.ACK:
                        if (SendStage == XmodemSendStage.PacketSending)
                        {
                            // 通知发下一包
                            if (SendNextPacket != null)
                            {
                                SendNextPacket(xmodemInfo, null);
                            }
                        }
                        else if (SendStage == XmodemSendStage.WaitReceiveAnswerEndTransmit)
                        {
                            // 通知中止
                            //if (AbortTransmit != null)
                            //{
                            //    AbortTransmit(xmodemInfo, null);
                            //}
                            if (EndOfTransmit != null)
                            {
                                EndOfTransmit(xmodemInfo, null);
                            }
                            IsStart = false;
                        }
                        break;

                    case XmodemMessageType.CAN:
                        // 通知中止
                        if (AbortTransmit != null)
                        {
                            AbortTransmit(xmodemInfo, null);
                        }
                        break;

                    default:
                        break;
                }
            }
            else
            {
                if (waitReceiveEvent.WaitOne(3000))
                {
                    waitReceiveEvent.Reset();

                }
                else
                {
                    reTryCount++;
                    if (reTryCount > RetryMax)
                    {
                        IsStart = false;
                        //通知接收超时
                        if (TransmitTimeOut != null)
                        {
                            TransmitTimeOut(xmodemInfo, null);
                        }
                    }
                }
            }

        }

        void ReceiveHandler()
        {
            if (ReceiveStage == XmodemReceiveStage.WaitForFirstPacket)
            {
                if (reTryCount % 2 == 0)
                {
                    xmodemInfo.CheckMode = XModemCheckMode.CheckSum;
                    SendKEYC();
                }
                else
                {
                    xmodemInfo.CheckMode = XModemCheckMode.CRC16;
                    SendNAK();
                }
            }


            XmodemMessage msg = null;
            lock (msgQueue)
            {
                if (msgQueue.Count > 0)
                {
                    msg = msgQueue.Dequeue();
                }

            }
            if (msg != null)
            {
                reTryCount = 0;

                switch (msg.MessageType)
                {
                    case XmodemMessageType.PACKET:
                        ReceiveStage = XmodemReceiveStage.PacketReceiving;
                        SendACK();
                        if (ReceivedPacket != null)
                        {
                            PacketEventArgs e = msg.Value as PacketEventArgs;
                            ReceivedPacket(xmodemInfo, new PacketEventArgs(e.PacketNo, e.Packet));
                        }

                        // 通知发下一包
                        if (SendNextPacket != null)
                        {
                            SendNextPacket(xmodemInfo, null);
                        }
                        break;
                    case XmodemMessageType.PACKET_ERROR:
                        SendNAK();
                        // 通知重发
                        if (ReSendPacket != null)
                        {
                            ReSendPacket(xmodemInfo, null);
                        }
                        break;
                    case XmodemMessageType.EOT:
                        SendACK();
                        // 通知完成
                        if (EndOfTransmit != null)
                        {
                            EndOfTransmit(xmodemInfo, null);
                        }
                        break;
                    case XmodemMessageType.CAN:
                        SendACK();
                        // 通知中止
                        if (AbortTransmit != null)
                        {
                            AbortTransmit(xmodemInfo, null);
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                if (waitReceiveEvent.WaitOne(3000))
                {
                    waitReceiveEvent.Reset();
                }
                else
                {
                    reTryCount++;
                    if (reTryCount > RetryMax)
                    {
                        IsStart = false;
                        //通知接收超时
                        if (TransmitTimeOut != null)
                        {
                            TransmitTimeOut(xmodemInfo, null);
                        }
                    }

                }
            }

        }


        #region IFileTramsmit 成员

        public event EventHandler StartSend;

        public event EventHandler StartReceive;

        public event EventHandler SendNextPacket;

        public event EventHandler ReSendPacket;

        public event EventHandler AbortTransmit;

        public event EventHandler EndOfTransmit;

        public event EventHandler TransmitTimeOut;

        public event PacketEventHandler ReceivedPacket;

        public void SendPacket(PacketEventArgs packet)
        {
            int packetLen = 0;
            int checkLen = 0;
            byte[] data;

            if (xmodemInfo.CheckMode == XModemCheckMode.CheckSum)
            {
                checkLen = 1;
            }
            else
            {
                checkLen = 2;
            }

            if (xmodemInfo.Type == XModemType.XModem_1K)
            {
                packetLen = 1024;
            }
            else
            {
                packetLen = 128;
            }

            data = new byte[3 + packetLen + checkLen];

            data[0] = SOH;
            if (xmodemInfo.Type == XModemType.XModem_1K)
            {
                data[0] = STX;
            }

            data[1] = Convert.ToByte(packet.PacketNo & 0xFF);
            data[2] = Convert.ToByte((~data[1]) & 0xFF);
            Array.Copy(packet.Packet, 0, data, 3, packetLen);

            if (xmodemInfo.CheckMode == XModemCheckMode.CheckSum)
            {
                data[3 + packetLen] = Convert.ToByte(DataCheck.GetCheckSum(packet.Packet) & 0xFF);
            }
            else
            {
                UInt16 crc = Convert.ToUInt16(DataCheck.GetCRC(CRCType.CRC16_XMODEM, packet.Packet) & 0xFFFF);
                data[3 + packetLen] = Convert.ToByte(crc >> 8);
                data[3 + packetLen + 1] = Convert.ToByte(crc & 0xFF);
            }

            SendFrameToUart(data);
        }

        #endregion


        #region ITransmitUart 成员

        public event SendToUartEventHandler SendToUartEvent;
        public void ReceivedFromUart(byte[] data)
        {
            ParseReceivedMessage(data);

        }
        #endregion
    }
}
