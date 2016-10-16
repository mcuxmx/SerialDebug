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
        YModem_G
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


        //private TransmitType TransType = TransmitType.Send;
        //private bool YMODEM_CRC = false;
        //private bool YMODEM_1K = false;
        private int RetryMax = 6;

        YModemInfo ymodemInfo = new YModemInfo();


        private Thread TransThread;
        private bool IsStart = false;
        private bool receiveWaitForFileInfo = true;        //接收方等待文件信息
        private bool receiveWaitForFirstPacket = true;     //接收方等待第一包数据


        private bool sendWaitFileHeaderInfoACK = false; //发送方等待头信息的确认
        private bool sendWaitReqFirstPacket = false;    //发送方等待发送第一包数据
        private bool sendWaitForEnd = false;

        private int reTryCount;
        private ManualResetEvent waitReceiveEvent = new ManualResetEvent(false);
        private YmodemMessage ReceivedMessage = null;


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
            ReceivedMessage = null;
            receiveWaitForFileInfo = true;
            receiveWaitForFirstPacket = false;

            sendWaitFileHeaderInfoACK = true;
            sendWaitReqFirstPacket = false;
            sendWaitForEnd = false;

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
            sendWaitForEnd = true;

           // IsStart = false;
            if (ymodemInfo.TransMode == TransmitMode.Receive)
            {
                SendCAN();

            }
            else
            {
                SendEOT();

                //int packetLen = ymodemInfo.Type == YModemType.YModem ? 128 : 1024;
                //byte[] endPacket = new byte[3+packetLen+2];
                //SendFrameToUart(endPacket);
                ////SendPacket(new PacketEventArgs(0, endPacket));
            }

            //if (EndOfTransmit != null)
            //{
            //    EndOfTransmit(ymodemInfo, null);
            //}
        }



        /// <summary>
        /// 解析数据
        /// </summary>
        /// <param name="data"></param>
        private void ParseReceivedMessage(byte[] data)
        {
            ReceivedMessage = null;

            if (data == null)
            {
                ReceivedMessage = null;
            }
            else
            {

                if (data[0] == EOT)
                {
                    ReceivedMessage = new YmodemMessage(YmodemMessageType.EOT);
                }
                else if (data[0] == CAN)
                {
                    ReceivedMessage = new YmodemMessage(YmodemMessageType.CAN);
                }
                else if (data[0] == NAK)
                {
                    ReceivedMessage = new YmodemMessage(YmodemMessageType.NAK);
                }
                else if (data[0] == ACK)
                {
                    ReceivedMessage = new YmodemMessage(YmodemMessageType.ACK);
                }
                else if (data[0] == KEY_C)
                {
                    ReceivedMessage = new YmodemMessage(YmodemMessageType.KEY_C);
                }
                else if (data[0] == STX || data[0] == SOH)
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

                    // int checkDataLen = ymodemInfo.CheckMode == YModemCheckMode.CheckSum ? 1 : 2;
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
                        //if (ymodemInfo.CheckMode == YModemCheckMode.CheckSum)
                        //{
                        //    frameCheckCode = data[3 + packetLen];
                        //    calCheckCode = Convert.ToByte(DataCheck.GetCheckSum(packet) & 0xFF);
                        //}
                        //else
                        //{
                        frameCheckCode = (data[3 + packetLen] << 8) + data[3 + packetLen + 1];
                        calCheckCode = Convert.ToUInt16(DataCheck.GetCRC(CRCType.CRC16_XMODEM, packet) & 0xFFFF);
                        //}

                        if (frameCheckCode == calCheckCode)
                        {
                            ReceivedMessage = new YmodemMessage(YmodemMessageType.PACKET, new PacketEventArgs(packetNo, packet));
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
            for (int i = 0; i < 5; i++)
            {
                SendFrameToUart(CAN);
                Thread.Sleep(1000);
            }

        }

        private void SendEOT()
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    SendFrameToUart(EOT);
            //    Thread.Sleep(1000);
            //}
            SendFrameToUart(EOT);
        }


        private void SendNoFilesToSend()
        {
            //int packetLen = ymodemInfo.Type == YModemType.YModem ? 128 : 1024;
            byte[] endPacket = new byte[3 + 128 + 2];
            endPacket[0] = 0x01;
            endPacket[1] = 0x00;
            endPacket[2] = 0xFF;
            SendFrameToUart(endPacket);


            //byte[] endPacket = new byte[packetLen];
            //endPacket[0] = 0;
            //endPacket[1] = 0x30;
            //endPacket[2] = 0x20;
            //endPacket[3] = 0x30;
            //endPacket[4] = 0x20;
            //endPacket[5] = 0x30;


            //PacketEventArgs e = new PacketEventArgs(0, endPacket);
            //SendPacket(e);

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
            if (waitReceiveEvent.WaitOne(3000))
            {
                waitReceiveEvent.Reset();
                if (ReceivedMessage != null)
                {
                    reTryCount = 0;

                    switch (ReceivedMessage.MessageType)
                    {
                        case YmodemMessageType.NAK:
                            if (sendWaitForEnd)
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
                            if (sendWaitFileHeaderInfoACK)
                            {
                                // 通知发头一包CRC
                                if (StartSend != null)
                                {
                                    StartSend(ymodemInfo, null);
                                }
                            }

                            else if (sendWaitReqFirstPacket)    //等待第一包
                            {
                                // 通知发下一包
                                if (SendNextPacket != null)
                                {
                                    SendNextPacket(ymodemInfo, null);
                                }
                            }

                            if (sendWaitForEnd)
                            {
                                sendWaitForEnd = false;
                                SendNoFilesToSend();
                            }
                           
                            break;
                        case YmodemMessageType.ACK:
                            if (sendWaitFileHeaderInfoACK)  //如果在等待头文件的确认
                            {
                                sendWaitFileHeaderInfoACK = false;
                                sendWaitReqFirstPacket = true;  // 开始等待接收方请求第一包数据


                                /* 不等待C直接发 */
                                sendWaitReqFirstPacket = false;
                                // 通知发下一包
                                if (SendNextPacket != null)
                                {
                                    SendNextPacket(ymodemInfo, null);
                                }
                            }
                            else if (sendWaitForEnd)
                            {
                                sendWaitForEnd = false;
                                SendNoFilesToSend();
                            }
                            else
                            {
                                sendWaitReqFirstPacket = false;
                                // 通知发下一包
                                if (SendNextPacket != null)
                                {
                                    SendNextPacket(ymodemInfo, null);
                                }
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
                            reTryCount++;
                            break;
                    }
                }
                else
                {
                    reTryCount++;
                }

                if (reTryCount > RetryMax)
                {
                    //通知发送超时
                    if (TransmitTimeOut != null)
                    {
                        TransmitTimeOut(ymodemInfo, null);
                    }
                }
            }
        }

        void ReceiveHandler()
        {
            if (receiveWaitForFileInfo || receiveWaitForFirstPacket)
            {
                //if (reTryCount % 2 == 0)
                //{
                //   // ymodemInfo.CheckMode = YModemCheckMode.CheckSum;
                //    SendKEYC();
                //}
                //else
                //{
                //   // ymodemInfo.CheckMode = YModemCheckMode.CRC16;
                //    SendNAK();
                //}

                SendKEYC();
            }


            if (waitReceiveEvent.WaitOne(3000))
            {
                waitReceiveEvent.Reset();
                if (ReceivedMessage != null)
                {
                    reTryCount = 0;

                    switch (ReceivedMessage.MessageType)
                    {
                        case YmodemMessageType.PACKET:

                            PacketEventArgs e = ReceivedMessage.Value as PacketEventArgs;

                            if (receiveWaitForFileInfo)
                            {
                                if (e.PacketNo == 0)
                                {
                                    receiveWaitForFileInfo = false;    //收到文件头信息
                                    receiveWaitForFirstPacket = true;  //等待接收第一包数据
                                    SendACK();

                                    if (ReceivedPacket != null)
                                    {
                                        ReceivedPacket(ymodemInfo, new PacketEventArgs(e.PacketNo, e.Packet));
                                    }
                                }
                                else
                                {
                                    SendNAK();
                                }
                                
                            }
                            else
                            {
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
                            SendNAK();
                            reTryCount++;
                            break;
                    }
                }
                else
                {
                    reTryCount++;
                }

                if (reTryCount > RetryMax)
                {
                    //通知接收超时
                    if (TransmitTimeOut != null)
                    {
                        TransmitTimeOut(ymodemInfo, null);
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

            //if (ymodemInfo.CheckMode == YModemCheckMode.CheckSum)
            //{
            //    checkLen = 1;
            //}
            //else
            //{
            //    checkLen = 2;
            //}
            checkLen = 2;

            if (ymodemInfo.Type == YModemType.YModem_G)
            {
                packetLen = 1024;
            }
            else
            {
                packetLen = 128;
            }

            data = new byte[3 + packetLen + checkLen];

            data[0] = SOH;
            if (ymodemInfo.Type == YModemType.YModem_G)
            {
                data[0] = STX;
            }

            data[1] = Convert.ToByte(packet.PacketNo & 0xFF);
            data[2] = Convert.ToByte((~data[1]) & 0xFF);
            Array.Copy(packet.Packet, 0, data, 3, packetLen);

            //if (ymodemInfo.CheckMode == YModemCheckMode.CheckSum)
            //{
            //    data[3 + packetLen] = Convert.ToByte(DataCheck.GetCheckSum(packet.Packet) & 0xFF);
            //}
            //else
            //{
            UInt16 crc = Convert.ToUInt16(DataCheck.GetCRC(CRCType.CRC16_XMODEM, packet.Packet) & 0xFFFF);
            data[3 + packetLen] = Convert.ToByte(crc >> 8);
            data[3 + packetLen + 1] = Convert.ToByte(crc & 0xFF);
            //}

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
