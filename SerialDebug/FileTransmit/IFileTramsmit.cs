using System;
using System.Collections.Generic;
using System.Text;

namespace XMX.FileTransmit
{
    public enum TransmitMode
    {
        Receive,
        Send
    }

    public delegate void PacketEventHandler(object sender, PacketEventArgs e);

    interface IFileTramsmit:ITransmitUart
    {


        event EventHandler StartSend;
        event EventHandler StartReceive;
        event EventHandler SendNextPacket;
        event EventHandler ReSendPacket;
        event EventHandler AbortTransmit;
        event EventHandler TransmitTimeOut;
        event EventHandler EndOfTransmit;

        event PacketEventHandler ReceivedPacket;


        void SendPacket(PacketEventArgs packet);
        void Start();
        void Stop();
        void Abort();

    }

    public class PacketEventArgs : EventArgs
    {
        private readonly int _PacketNo;
        private readonly int _PacketLen;
        private readonly byte[] _Packet;


        public PacketEventArgs(int packetNo, byte[] packet)
            : this(packetNo, packet, packet.Length)
        {

        }

        public PacketEventArgs(int packetNo, byte[] packet, int packetLen)
        {
            _PacketNo = packetNo;


            if (packet != null)
            {
                if (packet.Length <= packetLen)
                {
                    _PacketLen = packetLen;
                }

                _Packet = new byte[_PacketLen];
                Array.Copy(packet, 0, _Packet, 0, _PacketLen);
            }

        }

        public int PacketNo
        {
            get { return _PacketNo; }
        }

        public int PacketLen
        {
            get { return _PacketLen; }
        }

        public byte[] Packet
        {
            get { return _Packet; }
        }
    }

}
