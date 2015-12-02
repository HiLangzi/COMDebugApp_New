namespace COMDebugApp
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.comboBoxBate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonText = new System.Windows.Forms.RadioButton();
            this.radioButtonData = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_Data_SJT = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxData_Send = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxText_Send = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.checkBoxHCF13 = new System.Windows.Forms.CheckBox();
            this.checkBoxHHF10 = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(31, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "发送数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(324, 14);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(121, 29);
            this.comboBoxCOM.TabIndex = 1;
            // 
            // comboBoxBate
            // 
            this.comboBoxBate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxBate.FormattingEnabled = true;
            this.comboBoxBate.Items.AddRange(new object[] {
            "115200",
            "9600"});
            this.comboBoxBate.Location = new System.Drawing.Point(525, 12);
            this.comboBoxBate.Name = "comboBoxBate";
            this.comboBoxBate.Size = new System.Drawing.Size(121, 29);
            this.comboBoxBate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(244, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "串口号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(451, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "波特率：";
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.Location = new System.Drawing.Point(182, 62);
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxReceive.Size = new System.Drawing.Size(792, 150);
            this.textBoxReceive.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "接收的数据：";
            // 
            // radioButtonText
            // 
            this.radioButtonText.AutoSize = true;
            this.radioButtonText.Location = new System.Drawing.Point(91, 80);
            this.radioButtonText.Name = "radioButtonText";
            this.radioButtonText.Size = new System.Drawing.Size(47, 16);
            this.radioButtonText.TabIndex = 7;
            this.radioButtonText.Text = "文本";
            this.radioButtonText.UseVisualStyleBackColor = true;
            // 
            // radioButtonData
            // 
            this.radioButtonData.AutoSize = true;
            this.radioButtonData.Checked = true;
            this.radioButtonData.Location = new System.Drawing.Point(91, 102);
            this.radioButtonData.Name = "radioButtonData";
            this.radioButtonData.Size = new System.Drawing.Size(89, 16);
            this.radioButtonData.TabIndex = 8;
            this.radioButtonData.TabStop = true;
            this.radioButtonData.Text = "数据（HEX）";
            this.radioButtonData.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(668, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "打开串口";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_Data_SJT
            // 
            this.textBox_Data_SJT.Location = new System.Drawing.Point(182, 232);
            this.textBox_Data_SJT.Multiline = true;
            this.textBox_Data_SJT.Name = "textBox_Data_SJT";
            this.textBox_Data_SJT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Data_SJT.Size = new System.Drawing.Size(792, 47);
            this.textBox_Data_SJT.TabIndex = 10;
            this.textBox_Data_SJT.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(31, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 40);
            this.button3.TabIndex = 11;
            this.button3.Text = "刷新串口号";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(824, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 40);
            this.button4.TabIndex = 12;
            this.button4.Text = "关闭串口";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(986, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "数据体（HEX文本）：";
            // 
            // textBoxData_Send
            // 
            this.textBoxData_Send.Location = new System.Drawing.Point(182, 302);
            this.textBoxData_Send.Multiline = true;
            this.textBoxData_Send.Name = "textBoxData_Send";
            this.textBoxData_Send.Size = new System.Drawing.Size(792, 42);
            this.textBoxData_Send.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 39);
            this.label5.TabIndex = 19;
            this.label5.Text = "要发送数据的字符串形式（HEX文本）：";
            // 
            // textBoxText_Send
            // 
            this.textBoxText_Send.Location = new System.Drawing.Point(182, 359);
            this.textBoxText_Send.Multiline = true;
            this.textBoxText_Send.Name = "textBoxText_Send";
            this.textBoxText_Send.Size = new System.Drawing.Size(792, 109);
            this.textBoxText_Send.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "要发送的字符串：";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(31, 433);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 35);
            this.button5.TabIndex = 22;
            this.button5.Text = "发送字符串";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(31, 262);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 40);
            this.button6.TabIndex = 23;
            this.button6.Text = "增加开始符号、CRC校验以及结束符号";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(31, 124);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 35);
            this.button7.TabIndex = 24;
            this.button7.Text = "清空接收数据";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // checkBoxHCF13
            // 
            this.checkBoxHCF13.AutoSize = true;
            this.checkBoxHCF13.Checked = true;
            this.checkBoxHCF13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHCF13.Location = new System.Drawing.Point(31, 412);
            this.checkBoxHCF13.Name = "checkBoxHCF13";
            this.checkBoxHCF13.Size = new System.Drawing.Size(72, 16);
            this.checkBoxHCF13.TabIndex = 25;
            this.checkBoxHCF13.Text = "带回车符";
            this.checkBoxHCF13.UseVisualStyleBackColor = true;
            // 
            // checkBoxHHF10
            // 
            this.checkBoxHHF10.AutoSize = true;
            this.checkBoxHHF10.Checked = true;
            this.checkBoxHHF10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHHF10.Location = new System.Drawing.Point(101, 412);
            this.checkBoxHHF10.Name = "checkBoxHHF10";
            this.checkBoxHHF10.Size = new System.Drawing.Size(72, 16);
            this.checkBoxHHF10.TabIndex = 26;
            this.checkBoxHHF10.Text = "带换行符";
            this.checkBoxHHF10.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(986, 518);
            this.Controls.Add(this.checkBoxHHF10);
            this.Controls.Add(this.checkBoxHCF13);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.comboBoxBate);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxText_Send);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxData_Send);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox_Data_SJT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButtonData);
            this.Controls.Add(this.radioButtonText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxReceive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCOM);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口调试程序";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.ComboBox comboBoxBate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxReceive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonText;
        private System.Windows.Forms.RadioButton radioButtonData;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_Data_SJT;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxData_Send;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxText_Send;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox checkBoxHCF13;
        private System.Windows.Forms.CheckBox checkBoxHHF10;
    }
}

