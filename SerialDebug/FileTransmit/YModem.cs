using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace XMX.FileTransmit
{

    public enum YModemCheckMode
    {
        CheckSum,
        CRC16
    }

    public enum YModemType
    {
        YModem,
        YModem_1K
    }

    /// <summary>
    /// YModem接收到的消息类型
    /// </summary>
    enum YmodemMessageType : int
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
    /// YModem接收到的消息内容
    /// </summary>
    internal class YmodemMessage
    {
        private YmodemMessageType _MessageType;
        private object _Value;


        public YmodemMessage(YmodemMessageType type)
            : this(type, null)
        {

        }

        public YmodemMessage(YmodemMessageType type, object value)
        {
            _MessageType = type;
            _Value = value;
        }


        public YmodemMessageType MessageType
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
    internal enum YmodemSendStage : int
    {
        WaitReceiveRequestFileInfo,   //等待接收端请求文件头
        WaitReceiveRequestFirstPacket,
        PacketSending,
        WaitReceiveAnswerEndTransmit,   // 等待接收方应答EOT
        WaitReceiveNextFileReq,            // 等等接收方请求下一个文件
    }

    /// <summary>
    /// Xmodem接收步骤
    /// </summary>
    internal enum YmodemReceiveStage : int
    {
        WaitForFileInfo,
        WaitForFirstPacket,
        PacketReceiving,
    }

    public class YModemInfo
    {
        private YModemType _YModemType;
        private TransmitMode _TransType;

        public YModemInfo()
            : this(YModemType.YModem, TransmitMode.Send)
        {

        }

        public YModemInfo(YModemType type, TransmitMode transType)
        {
            _YModemType = type;
            _TransType = transType;
        }


        public YModemType Type
        {
            get { return _YModemType; }
            set { _YModemType = value; }
        }

        public TransmitMode TransMode
        {
            get { return _TransType; }
            set { _TransType = value; }
        }

        //public YModemCheckMode CheckMode
        //{
        //    get { return _CheckMode; }
        //    set { _CheckMode = value; }
        //}

    }

    public class YModem : IFileTramsmit, ITransmitUart
    {
        private readonly byte SOH = 0x01;
        private readonly byte STX = 0x02;
        private readonly byte EOT = 0x04;
        private readonly byte ACK = 0x06;
        private readonly byte NAK = 0x15;
        private readonly byte CAN = 0x18;
        private readonly byte KEY_C = 0x43; //'C';

        private int RetryMax = 6;

        YModemInfo ymodemInfo = new YModemInfo();


        private Thread TransThread;
        private bool IsStart = false;
   
        private int reTryCount;
        private ManualResetEvent waitReceiveEvent = new ManualResetEvent(false);
        private YmodemReceiveStage ReceiveStage;
        private YmodemSendStage SendStage;
        private Queue<YmodemMessage> msgQueue = new Queue<YmodemMessage>();

        public YModem(TransmitMode transType, YModemType ymodemType, int reTryCount)
        {
            RetryMax = reTryCount;

            ymodemInfo.Type = ymodemType;
            ymodemInfo.TransMode = transType;
        }

        public void Start()
        {
            IsStart = true;
            reTryCount = 0;

            ReceiveStage = YmodemReceiveStage.WaitForFileInfo;
            SendStage = YmodemSendStage.WaitReceiveRequestFileInfo;


            TransThread = new Thread(new ThreadStart(TransThreadHandler));
            TransThread.IsBackground = true;
            TransThread.Name = "YmodemTransThread";
            TransThread.Start();
            if (ymodemInfo.TransMode == TransmitMode.Receive)
            {
                if (StartReceive != null)
                {
                    StartReceive(ymodemInfo, null);
                }
            }
        }

        public void Stop()
        {
            if (ymodemInfo.TransMode == TransmitMode.Receive)
            {
                Abort();
            }
            else
            {
                SendEOT();

            }
            
        }

        public void Abort()
        {
            IsStart = false;
            SendCAN();

            if (EndOfTransmit != null)
            {
                EndOfTransmit(ymodemInfo, null);
            }
        }


        /// <summary>
        /// 解析数据
        /// </summary>
        /// <param name="data"></param>
        private void ParseReceivedMessage(byte[] data)
        {

            YmodemMessage ReceivedMessage = null;

            if (data == null)
            {
                ReceivedMessage = null;
            }
            else
            {
                if (data[0] == STX || data[0] == SOH)
                {
                    ReceivedMessage = new YmodemMessage(YmodemMessageType.PACKET_ERROR);
                    int packetLen = 0;
                    if (data[0] == STX)
                    {
                        packetLen = 1024;
                    }
                    else if (data[0] == SOH)
                    {
                        packetLen = 128;
                    }

                    int checkDataLen = 2;
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

                        frameCheckCode = (data[3 + packetLen] << 8) + data[3 + packetLen + 1];
                        calCheckCode = Convert.ToUInt16(DataCheck.GetCRC(CRCType.CRC16_XMODEM, packet) & 0xFFFF);
                        

                        if (frameCheckCode == calCheckCode)
                        {
                            ReceivedMessage = new YmodemMessage(YmodemMessageType.PACKET, new PacketEventArgs(packetNo, packet));
                        }

                    }
                }
                else
                {
                    foreach (byte b in data)
                    {
                        ReceivedMessage = null;

                        if (b == EOT)
                        {
                            ReceivedMessage = new YmodemMessage(YmodemMessageType.EOT);
                        }
                        else if (b == CAN)
                        {
                            ReceivedMessage = new YmodemMessage(YmodemMessageType.CAN);
                        }
                        else if (b == NAK)
                        {
                            ReceivedMessage = new YmodemMessage(YmodemMessageType.NAK);
                        }
                        else if (b == ACK)
                        {
                            ReceivedMessage = new YmodemMessage(YmodemMessageType.ACK);
                        }
                        else if (b == KEY_C)
                        {
                            ReceivedMessage = new YmodemMessage(YmodemMessageType.KEY_C);
                        }
                        else
                        {
                        }

                        if (ReceivedMessage!=null)
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
                SendToUartEvent(ymodemInfo, new SendToUartEventArgs(data));
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
            SendStage = YmodemSendStage.WaitReceiveAnswerEndTransmit;
        }


        private void SendNoFilesToSend()
        {
            //int packetLen = ymodemInfo.Type == YModemType.YModem ? 128 : 1024;
            byte[] endPacket = new byte[3 + 128 + 2];
            endPacket[0] = 0x01;
            endPacket[1] = 0x00;
            endPacket[2] = 0xFF;
            SendFrameToUart(endPacket);

            if (EndOfTransmit != null)
            {
                EndOfTransmit(ymodemInfo, null);
            }
            IsStart = false;
        }

        void TransThreadHandler()
        {
            while (IsStart)
            {
                if (ymodemInfo.TransMode == TransmitMode.Send)
                {
                    SendHandler();
                }
                else if (ymodemInfo.TransMode == TransmitMode.Receive)
                {
                    ReceiveHandler();
                }
            }
        }

        void SendHandler()
        {

            YmodemMessage msg;
            if (msgQueue.Count > 0)
            {
                msg = msgQueue.Dequeue();
                if (msg != null)
                {
                    reTryCount = 0;
                    switch (msg.MessageType)
                    {
                        case YmodemMessageType.NAK:
                            if (SendStage == YmodemSendStage.WaitReceiveAnswerEndTransmit)
                            {
                                SendEOT();
                            }
                            else
                            {
                                // 通知重发
                                if (ReSendPacket != null)
                                {
                                    ReSendPacket(ymodemInfo, null);
                                }

                            }

                            break;
                        case YmodemMessageType.KEY_C:
                            if (SendStage == YmodemSendStage.WaitReceiveRequestFileInfo)
                            {
                                // 通知发头一包CRC
                                if (StartSend != null)
                                {
                                    StartSend(ymodemInfo, null);
                                }
                            }
                            else if (SendStage == YmodemSendStage.WaitReceiveRequestFirstPacket)    //等待第一包
                            {
                                SendStage = YmodemSendStage.PacketSending;
                                // 通知发下一包
                                if (SendNextPacket != null)
                                {
                                    SendNextPacket(ymodemInfo, null);
                                }
                            }
                            else if (SendStage == YmodemSendStage.WaitReceiveNextFileReq)   //接收方请求下一个文件
                            {
                                SendNoFilesToSend();
                            }


                            break;
                        case YmodemMessageType.ACK:
                            if (SendStage == YmodemSendStage.WaitReceiveRequestFileInfo)
                            {
                                SendStage = YmodemSendStage.WaitReceiveRequestFirstPacket;  //等待接收方请求第一包数据
                            }
                            else if (SendStage == YmodemSendStage.PacketSending)
                            {
                                // 通知发下一包
                                if (SendNextPacket != null)
                                {
                                    SendNextPacket(ymodemInfo, null);
                                }
                            }
                            else if (SendStage == YmodemSendStage.WaitReceiveAnswerEndTransmit)
                            {
                                SendStage = YmodemSendStage.WaitReceiveNextFileReq; //等待接收方请求下一个文件
                            }

                            break;
                        case YmodemMessageType.CAN:
                            // 通知中止
                            if (AbortTransmit != null)
                            {
                                AbortTransmit(ymodemInfo, null);
                            }
                            break;
                        default:

                            break;
                    }

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
                            TransmitTimeOut(ymodemInfo, null);
                        }
                    }
                }
            }


        }

        void ReceiveHandler()
        {
            if (ReceiveStage == YmodemReceiveStage.WaitForFileInfo || ReceiveStage == YmodemReceiveStage.WaitForFirstPacket)
            {
                SendKEYC();
            }

            if (msgQueue.Count > 0)
            {
                YmodemMessage msg = msgQueue.Dequeue();
                if (msg != null)
                {
                    reTryCount = 0;

                    switch (msg.MessageType)
                    {
                        case YmodemMessageType.PACKET:

                            PacketEventArgs e = msg.Value as PacketEventArgs;
                            if (ReceiveStage == YmodemReceiveStage.WaitForFileInfo)
                            {
                                if (e.PacketNo == 0)
                                {
                                    ReceiveStage = YmodemReceiveStage.WaitForFirstPacket;
                                    SendACK();

                                    if (ReceivedPacket != null)
                                    {
                                        ReceivedPacket(ymodemInfo, new PacketEventArgs(e.PacketNo, e.Packet));
                                    }
                                }
                                //else
                                //{
                                //    SendNAK();
                                //}
                            }

                            else if (ReceiveStage == YmodemReceiveStage.WaitForFirstPacket ||
                                ReceiveStage == YmodemReceiveStage.PacketReceiving)
                            {
                                if (ReceiveStage == YmodemReceiveStage.WaitForFirstPacket)
                                {
                                    ReceiveStage = YmodemReceiveStage.PacketReceiving;
                                }

                                SendACK();

                                if (ReceivedPacket != null)
                                {
                                    ReceivedPacket(ymodemInfo, new PacketEventArgs(e.PacketNo, e.Packet));
                                }

                                // 通知发下一包
                                if (SendNextPacket != null)
                                {
                                    SendNextPacket(ymodemInfo, null);
                                }
                            }


                            break;
                        case YmodemMessageType.PACKET_ERROR:
                            SendNAK();
                            // 通知重发
                            if (ReSendPacket != null)
                            {
                                ReSendPacket(ymodemInfo, null);
                            }
                            break;
                        case YmodemMessageType.EOT:
                            SendACK();
                            // 通知完成
                            if (EndOfTransmit != null)
                            {
                                EndOfTransmit(ymodemInfo, null);
                            }
                            break;
                        case YmodemMessageType.CAN:
                            SendACK();
                            // 通知中止
                            if (AbortTransmit != null)
                            {
                                AbortTransmit(ymodemInfo, null);
                            }
                            break;
                        default:
                            break;
                    }
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
                            TransmitTimeOut(ymodemInfo, null);
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

            checkLen = 2;

            if (ymodemInfo.Type == YModemType.YModem_1K)
            {
                packetLen = 1024;
            }
            else
            {
                packetLen = 128;
            }

            data = new byte[3 + packetLen + checkLen];

            data[0] = SOH;
            if (ymodemInfo.Type == YModemType.YModem_1K)
            {
                data[0] = STX;
            }

            data[1] = Convert.ToByte(packet.PacketNo & 0xFF);
            data[2] = Convert.ToByte((~data[1]) & 0xFF);
            Array.Copy(packet.Packet, 0, data, 3, packetLen);

            UInt16 crc = Convert.ToUInt16(DataCheck.GetCRC(CRCType.CRC16_XMODEM, packet.Packet) & 0xFFFF);
            data[3 + packetLen] = Convert.ToByte(crc >> 8);
            data[3 + packetLen + 1] = Convert.ToByte(crc & 0xFF);


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
