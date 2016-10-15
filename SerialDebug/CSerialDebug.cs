using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;

namespace SerialDebug
{
    class CSerialDebug
    {


        private Queue<SerialDebugReceiveData> receiveQueue = new Queue<SerialDebugReceiveData>();
        private List<CSendParam> sendList = new List<CSendParam>();

        private SerialPort _serialPort = new SerialPort();
        private bool IsReceiveStart = false;
        private Thread receiveThread;
        private Thread parseThread;
        private bool IsSendStart = false;
        private Thread sendThread;
        private TimeSpan delayTime = new TimeSpan(10 * 400);


        public delegate void ReceivedEventHandler(object sender, SerialDebugReceiveData e);
        public event ReceivedEventHandler ReceivedEvent;

        public delegate void SendCompletedEventHandler(object sender, SendCompletedEventArgs e);
        public event SendCompletedEventHandler SendCompletedEvent;


        private AutoResetEvent waitReceiveEvent = new AutoResetEvent(false);
        private ManualResetEvent waitParseEvent = new ManualResetEvent(false);

        public SerialPort serialPort
        {
            get { return _serialPort; }
            set { _serialPort = value; }
        }

        private int LoopCount = 0;

        public void Start()
        {
            //waitReceiveEvent = new AutoResetEvent(false);

            IsReceiveStart = true;
            lock (receiveQueue)
            {
                receiveQueue.Clear();
            }

            lock (sendList)
            {
                sendList.Clear();
            }

            receiveThread = new Thread(new ThreadStart(ReceiveThreadHandler));
            receiveThread.IsBackground = true;
            receiveThread.Name = "receiveThread";
            receiveThread.Start();

            parseThread = new Thread(new ThreadStart(ParseThreadHandler));
            parseThread.IsBackground = true;
            parseThread.Name = "parseThread";
            parseThread.Start();
        }

        public void Stop()
        {
            IsReceiveStart = false;
            IsSendStart = false;
        }

        public void StopReceive()
        {
            IsReceiveStart = false;
        }

        public void StopSend()
        {
            IsSendStart = false;
        }
        public void Send(List<CSendParam> list)
        {
            LoopCount = 1;
            Send(list, LoopCount);
        }
        public void Send(List<CSendParam> list, int loop)
        {
            LoopCount = loop;
            sendList = list;
            IsSendStart = true;

            try
            {
                if (sendThread != null)
                {
                    if (sendThread.IsAlive)
                    {
                        sendThread.Abort();
                    }
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            sendThread = new Thread(new ThreadStart(SendThreadHandler));
            sendThread.IsBackground = true;
            sendThread.Name = "sendThread";
            sendThread.Start();
        }

        //public Queue<SerialDebugReceiveData> ReceiveQueue
        //{
        //    get { return receiveQueue; }
        //}

        /// <summary>
        /// 接收线程
        /// </summary>
        private void ReceiveThreadHandler()
        {
            while (IsReceiveStart)
            {
                try
                {
                    if (_serialPort.IsOpen)
                    {

                        DateTime startTime = DateTime.Now;

                        int dataLen = _serialPort.BytesToRead;

                        do
                        {
                            dataLen = _serialPort.BytesToRead;

                            while (true)
                            {
                                Thread.Sleep(delayTime);
                                TimeSpan ts = DateTime.Now - startTime;
                                if (ts.TotalMilliseconds >= 3)
                                {
                                    break;
                                }
                            }

                        } while (dataLen != _serialPort.BytesToRead);

                        if (dataLen != 0)
                        {
                            byte[] bytes = new byte[dataLen];
                            _serialPort.Read(bytes, 0, dataLen);

                            lock (receiveQueue)
                            {
                                receiveQueue.Enqueue(new SerialDebugReceiveData(bytes));
                            }

                            waitReceiveEvent.Set();
                        }
                    }
                    else
                    {
                        Thread.Sleep(10);
                    }

                }
                catch (System.Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }

            }
        }

        /// <summary>
        /// 接收消息处理线程
        /// </summary>
        private void ParseThreadHandler()
        {
            while (IsReceiveStart)
            {
                try
                {
                    SerialDebugReceiveData data = null;
                    lock (receiveQueue)
                    {
                        if (receiveQueue.Count > 0)
                        {
                            data = receiveQueue.Dequeue();
                        }
                    }

                    if (data != null)
                    {

                        if (ReceivedEvent != null)
                        {
                            ReceivedEvent(this, data);
                        }
                        waitParseEvent.Set();
                    }
                    else
                    {
                        waitReceiveEvent.WaitOne(10);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("数据处理线程：" + ex.Message);
                }
            }
        }

        /// <summary>
        /// 发送线程
        /// </summary>
        private void SendThreadHandler()
        {
            if (LoopCount == 0)
            {
                LoopCount = int.MaxValue;
            }
            while (LoopCount > 0 && IsSendStart)
            {
                LoopCount--;

                waitParseEvent.Reset();

                int index = 0;
                while (index < sendList.Count && IsSendStart)
                {
                    CSendParam sendParam = null;
                    lock (sendList)
                    {
                        sendParam = sendList[index];
                    }
                    index++;

                    if (sendParam != null)
                    {
                        if (sendParam.Mode == SendParamMode.SendAfterLastSend)
                        {

                        }
                        else if (sendParam.Mode == SendParamMode.SendAfterReceived)
                        {

                            waitParseEvent.WaitOne();

                        }


                        if (sendParam.DelayTime > 0)
                        {
                            DateTime startTime = DateTime.Now;
                            TimeSpan ts = DateTime.Now - startTime;
                            do
                            {
                                Thread.Sleep(delayTime);
                                ts = DateTime.Now - startTime;
                            } while (ts.TotalMilliseconds <= sendParam.DelayTime);
                        }

                        waitParseEvent.Reset();
                        if (_serialPort.IsOpen)
                        {
                            _serialPort.Write(sendParam.DataBytes, 0, sendParam.DataBytes.Length);

                            if (SendCompletedEvent != null)
                            {
                                SendCompletedEvent(this, new SendCompletedEventArgs(sendParam));
                            }
                        }
                        else
                        {
                            IsSendStart = false;
                        }
                    }

                }

            }


            if (SendCompletedEvent != null)
            {
                SendCompletedEvent(this, new SendCompletedEventArgs(null));
            }

        }
    }


    public class SerialDebugReceiveData : EventArgs
    {
        private readonly DateTime _ReceiveTime;
        private readonly byte[] _ReceiveData;
        private readonly int _DataLen;

        public SerialDebugReceiveData(byte[] data)
        {
            _ReceiveData = data;
            _ReceiveTime = DateTime.Now;
            if (data != null)
            {
                _DataLen = data.Length;
            }
            else
            {
                _DataLen = 0;
            }
        }

        public byte[] ReceiveData
        {
            get { return _ReceiveData; }
        }

        public DateTime ReceiveTime
        {
            get { return _ReceiveTime; }
        }

        public int DataLen
        {
            get { return _DataLen; }
        }

        public string TimeString
        {
            get
            {
                return string.Format("[{0}.{1:D3}]", _ReceiveTime.ToString("yyyy-MM-dd HH:mm:ss"), _ReceiveTime.Millisecond);
            }
        }

        public string HexString
        {
            get
            {
                return string.Format("{0} ", BitConverter.ToString(_ReceiveData).Replace('-', ' '));
            }
        }

        public string ASCIIString
        {
            get { return System.Text.ASCIIEncoding.Default.GetString(_ReceiveData); }
        }

        public string DecString
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                foreach (byte b in _ReceiveData)
                {
                    sb.AppendFormat("{0} ", Convert.ToInt32(b));
                }

                return sb.ToString();
            }

        }
    }

    public class SendCompletedEventArgs : EventArgs
    {
        private readonly DateTime _SendTime;
        private CSendParam _SendParam;

        public SendCompletedEventArgs(CSendParam sendParam)
        {
            _SendTime = DateTime.Now;
            _SendParam = sendParam;
        }

        public DateTime SendTime
        {
            get { return _SendTime; }
        }

        public CSendParam SendParam
        {
            get { return _SendParam; }
        }

        public string TimeString
        {
            get
            {
                return string.Format("[{0}.{1:D3}]", _SendTime.ToString("yyyy-MM-dd HH:mm:ss"), _SendTime.Millisecond);
            }
        }
    }
}
