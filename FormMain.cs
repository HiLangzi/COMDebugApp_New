using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO.Ports;

namespace COMDebugApp
{

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct IP_Structure
            {
              byte A;
              byte B;
              byte C;
              byte D;
            };
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NetworkParameters
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            byte[] MAC_Address;
            IP_Structure Local_IP_Addresses;
            IP_Structure Mask_Addresses;
            IP_Structure Gateway;  
            IP_Structure Server_IP_Addresses;  
            byte IsWrite;
            UInt16 Local_port;
            UInt16 Server_port;
        };
    public partial class FormMain : Form
    {
        const byte transport_Start_A = 0x3A;
        const byte transport_Start_B = 0xA3;
        const byte transport_End = 0x03;
        public FormMain()
        {
            InitializeComponent();
            UInt16 u161 = 2511;
            byte b1 = (byte)(u161>>8);
            Console.WriteLine(b1);

        }
        //// <summary>
        /// 结构体转byte数组
        /// </summary>
        /// <param name="structObj">要转换的结构体</param>
        /// <returns>转换后的byte数组</returns>
        public static byte[] StructToBytes(object structObj)
        {
            //得到结构体的大小
            int size = Marshal.SizeOf(structObj);
            //创建byte数组
            byte[] bytes = new byte[size];
            //分配结构体大小的内存空间
            IntPtr structPtr = Marshal.AllocHGlobal(size);
            //将结构体拷到分配好的内存空间
            Marshal.StructureToPtr(structObj, structPtr, false);
            //从内存空间拷到byte数组
            Marshal.Copy(structPtr, bytes, 0, size);
            //释放内存空间
            Marshal.FreeHGlobal(structPtr);
            //返回byte数组
            return bytes;
        }
        /// <summary>
        /// byte数组转结构体
        /// </summary>
        /// <param name="bytes">byte数组</param>
        /// <param name="type">结构体类型</param>
        /// <returns>转换后的结构体</returns>
        public static object BytesToStuct(byte[] bytes, Type type)
        {
            //得到结构体的大小
            int size = Marshal.SizeOf(type);
            //byte数组长度小于结构体的大小
            if (size > bytes.Length)
            {
                //返回空
                return null;
            }
            //分配结构体大小的内存空间
            IntPtr structPtr = Marshal.AllocHGlobal(size);
            //将byte数组拷到分配好的内存空间
            Marshal.Copy(bytes, 0, structPtr, size);
            //将内存空间转换为目标结构体
            object obj = Marshal.PtrToStructure(structPtr, type);
            //释放内存空间
            Marshal.FreeHGlobal(structPtr);
            //返回结构体
            return obj;
        }
        void SxCKH()
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            this.comboBoxCOM.Items.Clear();
            this.comboBoxCOM.Items.AddRange(ports);

            string[] bates = new string[2] {"115200","9600"};
            this.comboBoxBate.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxBate.Items.Clear();
            this.comboBoxBate.Items.AddRange(bates);
            this.comboBoxBate.SelectedIndex = 1;
            this.toolStripStatusLabel1.Text = "刷新串口号成功！";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string data_s = this.textBoxData_Send.Text.Trim();
            if (data_s == string.Empty)
            {
                this.toolStripStatusLabel1.Text = "发送数据不能为空，请输入！";
                return;
            }
            string[] datas = data_s.Split(new char[1] { '-' });

            byte[] data_send = new byte[datas.Length];
            for (int i = 0; i < datas.Length; i++)
            {
                data_send[i] = byte.Parse(datas[i],System.Globalization.NumberStyles.HexNumber);
            }
            if (this.serialPort1.IsOpen)
            {
                this.serialPort1.Write(data_send, 0, data_send.Length);                
                this.toolStripStatusLabel1.Text = String.Format("发送{0}个字节数据成功！", data_send.Length.ToString());
            }
            else
            {
                this.toolStripStatusLabel1.Text = "串口未打开，发送数据失败！";
            }

            //byte[] bytebuff = new byte[1024];
            //int readcount = this.serialPort1.Read(bytebuff, 0, 1024);
            //if (readcount == 28)
            //{
            //    MessageBox.Show(readcount.ToString());
            //    NetworkParameters networkparameters1 = (NetworkParameters)BytesToStuct(bytebuff, typeof(NetworkParameters));
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SxCKH();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.serialPort1.IsOpen)
            {
                this.serialPort1.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (this.comboBoxCOM.Text.Trim() == string.Empty)
            {
                this.toolStripStatusLabel1.Text = "串口号不能为空，请输入或选择！";
                return;
            }
            if (this.comboBoxBate.Text.Trim() == string.Empty)
            {
                this.toolStripStatusLabel1.Text = "波特率不能为空，请输入！";
                return;
            }
            if (this.serialPort1.IsOpen)
            {
                this.serialPort1.Close();
            }
            this.serialPort1.BaudRate = Convert.ToInt32(this.comboBoxBate.Text);
            this.serialPort1.PortName = this.comboBoxCOM.Text;
            this.serialPort1.ReadBufferSize = 1024;
            try
            {
                this.serialPort1.Open();
                this.toolStripStatusLabel1.Text = String.Format("打开串口{0},波特率为{1}成功！",this.serialPort1.PortName,
                    this.serialPort1.BaudRate);
            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = ex.Message;
            }
           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.serialPort1.IsOpen)
            {
                this.serialPort1.Close();
                this.toolStripStatusLabel1.Text = String.Format("关闭串口{0},波特率为{1}成功！", this.serialPort1.PortName,
                    this.serialPort1.BaudRate);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SxCKH();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.textBoxData_Send.Text = this.textBox_Data_SJT.Text;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string data_s = this.textBox_Data_SJT.Text.Trim();
            int databytes_len = data_s.Length / 2;
            int senddatabytes_len = 2 + 1 + databytes_len + 2 + 1;
            byte[] senddatas = new byte[senddatabytes_len];
            senddatas[0] = transport_Start_A;
            senddatas[1] = transport_Start_B;
            senddatas[2] = (byte)databytes_len;

            int senddatas_index = 0;
            int crcjy = 0;
            for (int i = 0; i < data_s.Length; i=i+2)
            {
                string data_str1 = data_s[i].ToString()+data_s[i+1].ToString();
                byte data_1 = byte.Parse(data_str1, System.Globalization.NumberStyles.HexNumber);
                senddatas[3 + senddatas_index] = data_1;
                senddatas_index++;
                crcjy = crcjy + data_1;
            }
            UInt16 crcjy_16 = Convert.ToUInt16(crcjy);
            byte crcjy_H = Convert.ToByte(crcjy_16 >> 8);
            senddatas[senddatabytes_len - 3] = crcjy_H;
            UInt16 crcjy_L = (UInt16)(crcjy_16 << 8);
            crcjy_L = (UInt16)(crcjy_L >> 8);
            senddatas[senddatabytes_len - 2] = (byte)crcjy_L;
            senddatas[senddatabytes_len - 1] = transport_End;

            string data_sendstr = BitConverter.ToString(senddatas);            
            this.textBoxData_Send.Text = data_sendstr;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.serialPort1.IsOpen)
            {
                string sendtext = textBoxText_Send.Text.Trim();
                if (this.checkBoxHCF13.Checked)
                {
                    sendtext = sendtext + "\r";
                }
                if (this.checkBoxHHF10.Checked)
                {
                    sendtext = sendtext + "\n";
                }
                this.serialPort1.Write(sendtext);
                this.toolStripStatusLabel1.Text = String.Format("发送{0}个字符数据成功！", textBoxText_Send.Text.Length);
            }
            else
            {
                this.toolStripStatusLabel1.Text = "串口未打开，发送数据失败！";
            }
        }
        public delegate void MyInvoke(byte[] str, int startindex, int length);
        MyInvoke myinvoke1;
        public void SetTxt(byte[] str, int startindex, int length)
        {
            if (this.radioButtonData.Checked)
            {
                string hexOutput = BitConverter.ToString(str, startindex, length).Replace("-", "");
                this.textBoxReceive.AppendText(hexOutput);
            }
            if (this.radioButtonText.Checked)
            {
                this.textBoxReceive.AppendText(System.Text.ASCIIEncoding.ASCII.GetString(str,startindex,length));
            }
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            SerialPort sp = (SerialPort)sender;    
            byte[] rb1 = new byte[255];
            int rb2 = sp.Read(rb1, 0, 255);
            if (rb2 > 0)
            {
                myinvoke1 = new MyInvoke(SetTxt);
                this.Invoke(myinvoke1, new object[3] { rb1, 0, rb2 });
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBoxReceive.Clear();
        }
    }


}
