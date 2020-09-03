using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace XMX.LIB
{
    public class StreamConverter
    {
        

        #region Array<--->AsciiString
        /// <summary>
        /// 字符串转字节数组
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <param name="startIndex">数组起始位置</param>
        /// <param name="length">要转换的长度</param>
        /// <returns></returns>
        static public byte[] AsciiStringToArray(Encoding encoding, string value, int startIndex, int length)
        {
            try
            {
                //Encoding code = System.Text.Encoding.GetEncoding("UTF-8");
                return encoding.GetBytes(value.Substring(startIndex, length));
                
                //return System.Text.ASCIIEncoding.Default.GetBytes(value.Substring(startIndex, length));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 字符串转字节数组
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <returns></returns>
        static public byte[] AsciiStringToArray( Encoding encoding, string value)
        {
            return AsciiStringToArray( encoding, value, 0, value.Length);
        }

        /// <summary>
        /// 数组转字符串
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <param name="startIndex">数组起始位置</param>
        /// <param name="length">要转换的长度</param>
        /// <returns></returns>
        static public string ArrayToAsciiString( Encoding encoding, byte[] value, int startIndex, int length)
        {
            try
            {
                //Encoding code = System.Text.Encoding.GetEncoding("UTF-8");
                return encoding.GetString(value, startIndex, length);
                //return System.Text.ASCIIEncoding.Default.GetString(value, startIndex, length);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 数组转字符串
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <returns></returns>
        static public string ArrayToAsciiString(Encoding encoding, byte[] value)
        {
            if (value != null)
                return ArrayToAsciiString( encoding, value, 0, value.Length);
            else
                return string.Empty;
        }
        #endregion

        #region Array<-->BinaryString

        /// <summary>
        /// 二进制字符串转字节数组
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <param name="startIndex">数组起始位置</param>
        /// <param name="length">要转换的长度</param>
        /// <returns></returns>
        static public byte[] BinaryStringToArray(string value, int startIndex, int length)
        {
            try
            {
                List<byte> list = new List<byte>();
                string binString = value.Substring(startIndex, length).Replace(" ", "");
                int i;
                for (i = 0; i < binString.Length; i += 8)
                {
                    int len = 8;
                    if (i + 8 <= binString.Length)
                    {
                        len = 8;
                    }
                    else
                    {
                        len = binString.Length - i;
                    }
                    byte b = Convert.ToByte(binString.Substring(i, len), 2);
                    list.Add(b);
                }

                return list.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 二进制字符串转字节数组
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <returns></returns>
        static public byte[] BinaryStringToArray(string value)
        {
            return BinaryStringToArray(value, 0, value.Length);
        }

        /// <summary>
        /// 字节数组转二进制字符串
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <param name="startIndex">数组起始位置</param>
        /// <param name="length">要转换的长度</param>
        /// <returns></returns>
        static public string ArrayToBinaryString(byte[] value, int startIndex, int length)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < length; i++)
                {
                    byte b = value[startIndex + i];
                    string s = Convert.ToString(b, 2).PadLeft(8, '0');
                    sb.Append(s);
                    sb.Append(" ");
                }
                return sb.ToString().Trim();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 字节数组转二进制字符串
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <returns></returns>
        static public string ArrayToBinaryString(byte[] value)
        {
            if (value != null)
                return ArrayToBinaryString(value, 0, value.Length);
            else
                return string.Empty;
        }

        #endregion

        #region Array<-->OctalString

        /// <summary>
        /// 八进制字符串转字节数组
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <param name="startIndex">数组起始位置</param>
        /// <param name="length">要转换的长度</param>
        /// <returns></returns>
        static public byte[] OctalStringToArray(string value, int startIndex, int length)
        {
            try
            {
                List<byte> list = new List<byte>();
                string[] strArray = value.Substring(startIndex, length).Split(new char[] { ',', ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in strArray)
                {
                    byte b = Convert.ToByte(Convert.ToInt32(s, 8) & 0xFF);
                    list.Add(b);
                }
                return list.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 八进制字符串转字节数组
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <returns></returns>
        static public byte[] OctalStringToArray(string value)
        {
            return OctalStringToArray(value, 0, value.Length);
        }

        /// <summary>
        /// 字节数组转八进制字符串
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <param name="startIndex">数组起始位置</param>
        /// <param name="length">要转换的长度</param>
        /// <returns></returns>
        static public string ArrayToOctalString(byte[] value, int startIndex, int length)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < length; i++)
                {
                    int b = value[startIndex + i];
                    sb.AppendFormat("{0} ", Convert.ToString(b, 8));
                }
                return sb.ToString().Trim();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 字节数组转八进制字符串
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <returns></returns>
        static public string ArrayToOctalString(byte[] value)
        {
            if (value != null)
                return ArrayToOctalString(value, 0, value.Length);
            else
                return string.Empty;
        }

        #endregion

        #region Array<-->DecimalString

        /// <summary>
        /// 十进制字符串转字节数组
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <param name="startIndex">数组起始位置</param>
        /// <param name="length">要转换的长度</param>
        /// <returns></returns>
        static public byte[] DecimalStringToArray(string value, int startIndex, int length)
        {
            try
            {
                List<byte> list = new List<byte>();
                string[] strArray = value.Substring(startIndex, length).Split(new char[] { ' ', ',', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in strArray)
                {
                    byte b = Convert.ToByte(Convert.ToInt32(s, 10) & 0xFF);
                    list.Add(b);
                }

                return list.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 十进制字符串转字节数组
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <returns></returns>
        static public byte[] DecimalStringToArray(string value)
        {
            return DecimalStringToArray(value, 0, value.Length);
        }

        /// <summary>
        /// 数组转十进制字符串
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <param name="startIndex">数组起始位置</param>
        /// <param name="length">要转换的长度</param>
        /// <returns></returns>
        static public string ArrayToDecimalString(byte[] value, int startIndex, int length)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < length; i++)
                {
                    int b = value[startIndex + i];
                    sb.AppendFormat("{0} ", Convert.ToString(b, 10));
                }
                return sb.ToString().Trim();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 数组转十进制字符串
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <returns></returns>
        static public string ArrayToDecimalString(byte[] value)
        {
            if (value != null)
                return ArrayToDecimalString(value, 0, value.Length);
            else
                return string.Empty;
        }

        #endregion

        #region Array<-->HexString

        /// <summary>
        /// 十进制字符串转字节数组
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <param name="startIndex">数组起始位置</param>
        /// <param name="length">要转换的长度</param>
        /// <returns></returns>
        static public byte[] HexStringToArray(string value, int startIndex, int length)
        {
            try
            {
                List<byte> list = new List<byte>();
                string inputText = Regex.Replace(value.Substring(startIndex, length), @"[0-9A-Fa-f]{2}", "$0 ");
                string[] strArray = inputText.Split(new string[] { ",", " ", "0x", ",0X", "，", "(", ")","\r","\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in strArray)
                {
                    list.Add(Convert.ToByte(s, 16));
                }
                return list.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 十进制字符串转字节数组
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <returns></returns>
        static public byte[] HexStringToArray(string value)
        {
            return HexStringToArray(value, 0, value.Length);
        }

        /// <summary>
        /// 数组转十六进制字符串
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <param name="startIndex">数组起始位置</param>
        /// <param name="length">要转换的长度</param>
        /// <returns></returns>
        static public string ArrayToHexString(byte[] value, int startIndex, int length)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < length; i++)
                {
                    int b = value[startIndex + i];
                    sb.AppendFormat("{0:X2} ", b);
                }
                return sb.ToString().Trim();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 数组转十进制字符串
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <returns></returns>
        static public string ArrayToHexString(byte[] value)
        {
            if (value != null)
                return ArrayToHexString(value, 0, value.Length);
            else
                return string.Empty;
        }


        #endregion

        #region Text<-->HexString
        static public string TextToHexString(string text)
        {
            byte[] bytes = Encoding.Default.GetBytes(text);
            return BitConverter.ToString(bytes).Replace("-", "");
        }

        static public string HexStringToText(string hexStr)
        {
            byte[] bytes = HexStringToArray(hexStr);
            return Encoding.Default.GetString(bytes);
        }

        #endregion

        #region Array<-->Base64
        /// <summary>
        /// Base64字符串转字节数组
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <param name="startIndex">数组起始位置</param>
        /// <param name="length">要转换的长度</param>
        /// <returns></returns>
        static public byte[] Base64StringToArray(string value, int startIndex, int length)
        {
            try
            {
                return Convert.FromBase64String(value.Substring(startIndex, length));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Base64字符串转字节数组
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <returns></returns>
        static public byte[] Base64StringToArray(string value)
        {
            return Base64StringToArray(value, 0, value.Length);
        }

        /// <summary>
        /// 数组转Base64字符串
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <param name="startIndex">数组起始位置</param>
        /// <param name="length">要转换的长度</param>
        /// <returns></returns>
        static public string ArrayToBase64String(byte[] value, int startIndex, int length)
        {
            try
            {
                return Convert.ToBase64String(value, startIndex, length, Base64FormattingOptions.None);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 数组转字符串
        /// </summary>
        /// <param name="value">要转换的数组</param>
        /// <returns></returns>
        static public string ArrayToBase64String(byte[] value)
        {
            if (value != null)
                return ArrayToBase64String( value, 0, value.Length);
            else
                return string.Empty;
        }
        #endregion

        #region Array-->String

        static private string _ArrayToString<T>(  T [] value, int startIndex, int length, int toBase)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < length; i++)
                {
                    T b = value[startIndex + i];
                    sb.AppendFormat("{0} ", Convert.ToString(Convert.ToInt32(b), toBase));
                }
                return sb.ToString().Trim();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public string ArrayToString(int[] value, int startIndex, int length, int toBase)
        {
            return _ArrayToString(value, startIndex, length, toBase);
        }
        static public string ArrayToString(int[] value, int startIndex, int length)
        {
            return ArrayToString(value, startIndex, length, 16);
        }
        static public string ArrayToString(int[] value, int toBase)
        {
            if (value != null)
            {
                return ArrayToString(value, 0, value.Length, toBase);
            }
            else
            {
                return "";
            }
        }
        static public string ArrayToString(int[] value)
        {
            return ArrayToString(value, 16);
        }


        static public string ArrayToString(byte[] value, int startIndex, int length, int toBase)
        {
            return _ArrayToString(value, startIndex, length, toBase);
        }
        static public string ArrayToString(byte[] value, int startIndex, int length)
        {
            return ArrayToString(value, startIndex, length, 16);
        }
        static public string ArrayToString(byte[] value, int toBase)
        {
            if (value != null)
            {
                return ArrayToString(value, 0, value.Length, toBase);
            }
            else
            {
                return "";
            }
        }
        static public string ArrayToString(byte[] value)
        {
            return ArrayToString(value, 16);
        }

        #endregion


    }
}
