using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XMX.FileTransmit;
using System.IO.Ports;
using System.IO;

namespace SerialDebug
{
    public enum FileTransmitMode : int
    {
        ASCII = 0,
        Binary,
        Xmodem,
        Xmodem_1K,
        Ymodem,
        Ymodem_G
    }




    public partial class FormFileSend : Form
    {
        FileTransmitMode _FileTransMode = FileTransmitMode.ASCII;

        IFileTramsmit FileTransProtocol;
        private int fileIndex = 0;
        private int packetNo = 0;
        private byte[] PacketBuff;
        private int PacketLen = 128;

        public event EventHandler StartTransmitFile;
        public event EventHandler EndTransmitFile;
        public event SendToUartEventHandler SendToUartEvent;

        public FormFileSend()
        {
            InitializeComponent();
        }


        private void FormFileSend_Load(object sender, EventArgs e)
        {
            cbFileProtocol.Items.Clear();
            cbFileProtocol.Items.Add("ASCII");
            cbFileProtocol.Items.Add("Binary");
            cbFileProtocol.Items.Add("Xmodem");
            cbFileProtocol.Items.Add("Xmodem-1K");
            cbFileProtocol.Items.Add("Ymodem");
            cbFileProtocol.Items.Add("Ymodem-G");


            cbFileProtocol.SelectedIndex = 0;
            _FileTransMode = FileTransmitMode.ASCII;

        }

        public FileTransmitMode Mode
        {
            get { return _FileTransMode; }
        }


        public void Start()
        {
            if (txtFile.Text == string.Empty)
            {
                throw new Exception("未选择任何文件，请选择文件！");
            }

            switch (_FileTransMode)
            {
                case FileTransmitMode.ASCII:

                    FileTransProtocol = new BinarySend(Convert.ToInt32(numDelayTime.Value));
                    break;
                case FileTransmitMode.Binary:
                    PacketLen = Convert.ToInt32(numPacketLen.Value);
                    FileTransProtocol = new BinarySend(Convert.ToInt32(numDelayTime.Value));
                    break;
                case FileTransmitMode.Xmodem: // Xmodem
                    FileTransProtocol = new XModem(TransmitMode.Send, XModemType.XModem, 6);
                    PacketLen = 128;
                    break;
                case FileTransmitMode.Xmodem_1K: // Xmodem-1k
                    FileTransProtocol = new XModem(TransmitMode.Send, XModemType.XModem_1K, 6);
                    PacketLen = 1024;
                    break;
                case FileTransmitMode.Ymodem:
                    FileTransProtocol = new YModem(TransmitMode.Send, YModemType.YModem, 6);
                    PacketLen = 128;
                    break;
                case FileTransmitMode.Ymodem_G:
                    FileTransProtocol = new YModem(TransmitMode.Send, YModemType.YModem_G, 6);
                    PacketLen = 1024;
                    break;
                default:

                    break;
            }

            if (FileTransProtocol != null)
            {
                FileTransProtocol.EndOfTransmit += new EventHandler(xmodem_EndOfTransmit);
                FileTransProtocol.AbortTransmit += new EventHandler(xmodem_AbortTransmit);
                FileTransProtocol.ReSendPacket += new EventHandler(xmodem_ReSendPacket);
                FileTransProtocol.SendNextPacket += new EventHandler(xmodem_SendNextPacket);
                FileTransProtocol.TransmitTimeOut += new EventHandler(xmodem_TransmitTimeOut);
                FileTransProtocol.StartSend += new EventHandler(xmodem_StartSend);
                FileTransProtocol.SendToUartEvent += new SendToUartEventHandler(xmodem_SendToUartEvent);
            }

            packetNo = 1;
            fileIndex = 0;
            FileTransProtocol.Start();

            if (StartTransmitFile != null)
            {
                StartTransmitFile(this, null);
            }
        }

        public void Stop()
        {
            FileTransProtocol.Stop();

            SetEndTransmit();

            if (FileTransProtocol != null)
            {
                FileTransProtocol.EndOfTransmit -= new EventHandler(xmodem_EndOfTransmit);
                FileTransProtocol.AbortTransmit -= new EventHandler(xmodem_AbortTransmit);
                FileTransProtocol.ReSendPacket -= new EventHandler(xmodem_ReSendPacket);
                FileTransProtocol.SendNextPacket -= new EventHandler(xmodem_SendNextPacket);
                FileTransProtocol.TransmitTimeOut -= new EventHandler(xmodem_TransmitTimeOut);
                FileTransProtocol.StartSend -= new EventHandler(xmodem_StartSend);
                FileTransProtocol.SendToUartEvent -= new SendToUartEventHandler(xmodem_SendToUartEvent);
            }
        }

        public void ReceivedFromUart(byte[] data)
        {
            FileTransProtocol.ReceivedFromUart(data);
        }

        private void ShowProgressReport(bool IsShow, int value, int max)
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.BeginInvoke(new MethodInvoker(delegate
                {
                    ShowProgressReport(IsShow, value, max);
                }));
            }
            else
            {
                progressBar1.Visible = IsShow;
                progressBar1.Maximum = max;
                progressBar1.Value = value;
            }
        }

        private void SetEndTransmit()
        {
            ShowProgressReport(false, 0, 100);

            if (EndTransmitFile != null)
            {
                EndTransmitFile(this, null);
            }

        }

        private int ReadPacketFromFile(int filePos, byte[] data, int packetLen)
        {

            FileStream fs = new FileStream(txtFile.Text, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            try
            {
                if (filePos < fs.Length)
                {
                    fs.Seek(filePos, SeekOrigin.Begin);
                    int len = br.Read(data, 0, packetLen);

                    ShowProgressReport(true, filePos, (int)fs.Length);

                    return len;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show(ex.Message, oFileDlg.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                br.Close();
                fs.Close();
            }
        }

        private byte[] ReadAllFromFile()
        {
            FileStream fs = new FileStream(txtFile.Text, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            try
            {

                byte[] bytes = new byte[(UInt32)fs.Length];
                br.Read(bytes, 0, bytes.Length);

                return bytes;
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show(ex.Message, oFileDlg.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                br.Close();
                fs.Close();
            }
        }



        private string ReadLineFromFile()
        {
            FileStream fs = new FileStream(txtFile.Text, FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            // BinaryReader br = new BinaryReader(fs);
            try
            {

                if (fileIndex < fs.Length)
                {
                    fs.Seek(fileIndex, SeekOrigin.Begin);

                    string line = "";
                    char c;
                    while (sr.Peek() == '\r' || sr.Peek() == '\n')
                    {
                        fileIndex++;
                        c = Convert.ToChar(sr.Read());
                        if (chkSendCRRF.Checked)
                        {
                            line += c;
                        }

                    }

                    string str = sr.ReadLine();
                    fileIndex += System.Text.ASCIIEncoding.Default.GetBytes(str).Length;
                    line += str;


                    while (sr.Peek() == '\r' || sr.Peek() == '\n')
                    {
                        fileIndex++;
                        c = Convert.ToChar(sr.Read());
                        if (chkSendCRRF.Checked)
                        {
                            line += c;
                        }
                    }


                    return line;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show(ex.Message, oFileDlg.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sr.Close();
                fs.Close();
            }
        }

        void xmodem_SendToUartEvent(object sender, SendToUartEventArgs e)
        {
            if (SendToUartEvent != null)
            {
                SendToUartEvent(sender, e);
            }
        }

        void xmodem_StartSend(object sender, EventArgs e)
        {
            PacketBuff = new byte[PacketLen];

            if (_FileTransMode == FileTransmitMode.Xmodem || _FileTransMode == FileTransmitMode.Xmodem_1K)
            {
                packetNo = 1;

                if (ReadPacketFromFile(fileIndex, PacketBuff, PacketLen) <= 0)
                {
                    FileTransProtocol.Stop();
                }
                else
                {
                    FileTransProtocol.SendPacket(new PacketEventArgs(packetNo, PacketBuff));
                }
            }
            else if (_FileTransMode == FileTransmitMode.Ymodem || _FileTransMode == FileTransmitMode.Ymodem_G)
            {
                packetNo = 0;

                FileInfo fileInfo = new FileInfo(txtFile.Text);

                byte[] fileNameBytes = System.Text.ASCIIEncoding.Default.GetBytes(fileInfo.Name);

                int index = 0;
                Array.Copy(fileNameBytes, 0, PacketBuff, 0, fileNameBytes.Length);
                index += fileNameBytes.Length;
                PacketBuff[index] = 0;
                index++;
                byte[] fileSizeBytes = System.Text.ASCIIEncoding.Default.GetBytes(fileInfo.Length.ToString());
                Array.Copy(fileSizeBytes, 0, PacketBuff, index, fileSizeBytes.Length);

                FileTransProtocol.SendPacket(new PacketEventArgs(0, PacketBuff));

                fileIndex = 0;
                packetNo = 0;

                //fileInfo.Name;
            }
        }

        void xmodem_TransmitTimeOut(object sender, EventArgs e)
        {
            SetEndTransmit();
        }

        void xmodem_SendNextPacket(object sender, EventArgs e)
        {
            if (_FileTransMode == FileTransmitMode.ASCII)
            {
                if (chkSendByLine.Checked)
                {
                    string line = ReadLineFromFile();
                    if (line != null)
                    {
                        FileTransProtocol.SendPacket(new PacketEventArgs(packetNo, System.Text.ASCIIEncoding.Default.GetBytes(line)));
                        packetNo++;
                    }
                    else
                    {
                        FileTransProtocol.Stop();
                    }
                }
                else
                {
                    byte[] bytes = ReadAllFromFile();
                    if (packetNo == 1)
                    {
                        FileTransProtocol.SendPacket(new PacketEventArgs(packetNo, bytes));
                        packetNo++;
                    }
                    else
                    {
                        FileTransProtocol.Stop();
                    }
                }
            }
            else if (_FileTransMode == FileTransmitMode.Binary)
            {
                if (chkSlipPacket.Checked)
                {
                    PacketBuff = new byte[PacketLen];
                    packetNo++;
                    fileIndex += PacketLen;

                    if (ReadPacketFromFile(fileIndex, PacketBuff, PacketLen) <= 0)
                    {
                        FileTransProtocol.Stop();
                    }
                    else
                    {
                        FileTransProtocol.SendPacket(new PacketEventArgs(packetNo, PacketBuff));
                    }
                }
                else
                {
                    byte[] bytes = ReadAllFromFile();
                    if (packetNo == 1)
                    {
                        FileTransProtocol.SendPacket(new PacketEventArgs(1, bytes));
                        packetNo++;
                    }
                    else
                    {
                        FileTransProtocol.Stop();
                    }
                }
            }
            else
            {
                PacketBuff = new byte[PacketLen];
                packetNo++;
                fileIndex += PacketLen;

                if (packetNo == 1)
                {
                    fileIndex = 0;
                }

                int readBytes = ReadPacketFromFile(fileIndex, PacketBuff, PacketLen);
                if (readBytes <= 0)
                {
                    FileTransProtocol.Stop();
                }
                else
                {
                    if (_FileTransMode == FileTransmitMode.Ymodem || _FileTransMode== FileTransmitMode.Ymodem_G)
                    {
                        if (readBytes<PacketLen)
                        {
                            for (int i = readBytes; i < PacketLen;i++ )
                            {
                                PacketBuff[i] = 0x1A;
                            }
                        }
                    }
                    FileTransProtocol.SendPacket(new PacketEventArgs(packetNo, PacketBuff));

                }
            }


        }

        void xmodem_ReSendPacket(object sender, EventArgs e)
        {
            FileTransProtocol.SendPacket(new PacketEventArgs(packetNo, PacketBuff));
        }

        void xmodem_AbortTransmit(object sender, EventArgs e)
        {
            SetEndTransmit();
        }

        void xmodem_EndOfTransmit(object sender, EventArgs e)
        {
            SetEndTransmit();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFileDlg = new OpenFileDialog();

            oFileDlg.Filter = "文本文件(*.txt)|*.txt|二进制文件(*.bin)|*.bin|所有文件(*.*)|*.*";
            if (oFileDlg.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = oFileDlg.FileName;
            }
        }

        private void cbFileProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFileProtocol.SelectedIndex < 0)
            {
                return;
            }

            chkSendByLine.Visible = false;
            chkSendCRRF.Visible = false;
            chkSlipPacket.Visible = false;
            numPacketLen.Visible = false;
            labDelayTime.Visible = false;
            numDelayTime.Visible = false;


            _FileTransMode = (FileTransmitMode)cbFileProtocol.SelectedIndex;
            switch (_FileTransMode)
            {
                case FileTransmitMode.ASCII:
                    chkSendByLine.Visible = true;
                    labDelayTime.Visible = true;
                    chkSendCRRF.Visible = true;
                    numDelayTime.Visible = true;
                    break;
                case FileTransmitMode.Binary:
                    chkSlipPacket.Visible = true;
                    numPacketLen.Visible = true;
                    labDelayTime.Visible = true;
                    numDelayTime.Visible = true;
                    break;
            }
        }


    }
}