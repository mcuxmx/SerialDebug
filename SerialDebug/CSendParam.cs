using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using XMX.LIB;

namespace SerialDebug
{
    public class CSendParam
    {
        private SendParamFormat _Format;
        private SendParamMode _Mode;
        private int _DelayTime;
        private readonly string _Data;
        private readonly byte[] _DataBytes = null;

        public CSendParam(  SendParamFormat format, SendParamMode mode, int delayTime, byte[] data, int startIndex, int count)
        {
            _Format = format;
            _Mode = mode;
            _DelayTime = delayTime;
            _Data = string.Empty;
            if (data != null)
            {
                _DataBytes = new byte[count];
                Array.Copy(data, startIndex, _DataBytes, 0, count);

                if (Format == SendParamFormat.Hex)
                {
                    _Data = StreamConverter.ArrayToHexString(data, startIndex, count);
                }
                else
                {
                    _Data = StreamConverter.ArrayToAsciiString(Global.Encode, _DataBytes, startIndex, count);
                }
            }
        }

        public CSendParam( SendParamFormat format, SendParamMode mode, int delayTime, string data)
        {
            _Format = format;
            _Mode = mode;
            _DelayTime = delayTime;
            _Data = data;

            switch (_Format)
            {
                case SendParamFormat.ASCII:
                    _DataBytes= StreamConverter.AsciiStringToArray(Global.Encode, data);
                    break;
                case SendParamFormat.Hex:
                    _DataBytes = StreamConverter.HexStringToArray(data);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 十六进制字符串转十进制。
        /// </summary>
        /// <param name="hexStr"></param>
        /// <returns></returns>
        byte HexStringToByte(string hexStr)
        {
            return Convert.ToByte(hexStr, 16);
        }

        public SendParamFormat Format
        {
            get { return _Format; }
            set { _Format = value; }
        }

        public SendParamMode Mode
        {
            get { return _Mode; }
            set { _Mode = value; }
        }

        public int DelayTime
        {
            get { return _DelayTime; }
            set { _DelayTime = value; }
        }

        public int DataLen
        {
            get
            {
                if (_DataBytes != null)
                {
                    return _DataBytes.Length;
                }
                else
                {
                    return 0;
                }
            }
        }

        public string Data
        {
            get { return _Data; }
        }

        public string HexString
        {
            get
            {
                return StreamConverter.ArrayToHexString(_DataBytes);
            }
        }

        public string ASCIIString
        {
            get 
            {
                return StreamConverter.ArrayToAsciiString(Global.Encode, _DataBytes);
            }
        }

        public string DecString
        {
            get
            {
                return StreamConverter.ArrayToDecimalString(_DataBytes);
            }

        }

        public byte[] DataBytes
        {
            get
            {
                return _DataBytes;
            }
        }


        public string ParameterString
        {
            get
            {
                return string.Format("{0}:{1}:{2}", (int)_Format, (int)_Mode, _DelayTime);
            }
        }
    }


    public enum SendParamFormat : int
    {
        ASCII = 0,
        Hex = 1
    }

    public enum SendParamMode : int
    {
        //SendDelayTime = 0,// 启动后延时发送
        SendAfterLastSend = 0,//上帧发送完成后
        SendAfterReceived = 1//接收到数据帧后
    }
}
