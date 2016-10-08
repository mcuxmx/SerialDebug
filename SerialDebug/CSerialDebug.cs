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

        private SerialPort _serialPort = new SerialPort();
        private bool IsStart = false;
        private Thread receiveThread;

        public SerialPort serialPort
        {
            get { return _serialPort; }
            set { _serialPort = value; }
        }


        public void Start()
        {
            IsStart = true;
            lock (receiveQueue)
            {
                receiveQueue.Clear();
            }

            receiveThread = new Thread(new ThreadStart(ReceiveThreadHandler));
            receiveThread.IsBackground = true;
            receiveThread.Name = "receiveThread";
            receiveThread.Start();
        }

        public void Stop()
        {
            IsStart = false;
        }

        public Queue<SerialDebugReceiveData> ReceiveQueue
        {
            get { return receiveQueue; }
        }

        private void ReceiveThreadHandler()
        {
            while (IsStart)
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
                                Thread.Sleep(new TimeSpan(10 * 500));
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
    }


    internal class SerialDebugReceiveData
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
}
