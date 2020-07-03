namespace ModbusRTUSlave
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlCOMStatus = new System.Windows.Forms.Panel();
            this.cmbStopBit = new System.Windows.Forms.ComboBox();
            this.btCloseCOM = new System.Windows.Forms.Button();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.btOpenCOM = new System.Windows.Forms.Button();
            this.cmbDataBit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labStopBit = new System.Windows.Forms.Label();
            this.labParity = new System.Windows.Forms.Label();
            this.labBaud = new System.Windows.Forms.Label();
            this.labDataBit = new System.Windows.Forms.Label();
            this.labPort = new System.Windows.Forms.Label();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lb_p = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCOMStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCOMStatus
            // 
            this.pnlCOMStatus.Controls.Add(this.cmbStopBit);
            this.pnlCOMStatus.Controls.Add(this.btCloseCOM);
            this.pnlCOMStatus.Controls.Add(this.cmbParity);
            this.pnlCOMStatus.Controls.Add(this.btOpenCOM);
            this.pnlCOMStatus.Controls.Add(this.cmbDataBit);
            this.pnlCOMStatus.Controls.Add(this.label7);
            this.pnlCOMStatus.Controls.Add(this.labStopBit);
            this.pnlCOMStatus.Controls.Add(this.labParity);
            this.pnlCOMStatus.Controls.Add(this.labBaud);
            this.pnlCOMStatus.Controls.Add(this.labDataBit);
            this.pnlCOMStatus.Controls.Add(this.labPort);
            this.pnlCOMStatus.Controls.Add(this.cmbBaud);
            this.pnlCOMStatus.Controls.Add(this.cmbPort);
            this.pnlCOMStatus.Location = new System.Drawing.Point(-1, 44);
            this.pnlCOMStatus.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCOMStatus.Name = "pnlCOMStatus";
            this.pnlCOMStatus.Size = new System.Drawing.Size(541, 109);
            this.pnlCOMStatus.TabIndex = 34;
            // 
            // cmbStopBit
            // 
            this.cmbStopBit.Font = new System.Drawing.Font("Arial", 8F);
            this.cmbStopBit.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbStopBit.Location = new System.Drawing.Point(452, 44);
            this.cmbStopBit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStopBit.Name = "cmbStopBit";
            this.cmbStopBit.Size = new System.Drawing.Size(73, 24);
            this.cmbStopBit.TabIndex = 32;
            // 
            // btCloseCOM
            // 
            this.btCloseCOM.Enabled = false;
            this.btCloseCOM.Font = new System.Drawing.Font("Arial", 8F);
            this.btCloseCOM.Location = new System.Drawing.Point(423, 76);
            this.btCloseCOM.Margin = new System.Windows.Forms.Padding(4);
            this.btCloseCOM.Name = "btCloseCOM";
            this.btCloseCOM.Size = new System.Drawing.Size(104, 29);
            this.btCloseCOM.TabIndex = 45;
            this.btCloseCOM.Text = "Close";
            this.btCloseCOM.Click += new System.EventHandler(this.btCloseCOM_Click);
            // 
            // cmbParity
            // 
            this.cmbParity.Font = new System.Drawing.Font("Arial", 8F);
            this.cmbParity.Items.AddRange(new object[] {
            "0-None Parity",
            "1-Odd Parity",
            "2-Even Parity"});
            this.cmbParity.Location = new System.Drawing.Point(301, 44);
            this.cmbParity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(132, 24);
            this.cmbParity.TabIndex = 31;
            // 
            // btOpenCOM
            // 
            this.btOpenCOM.Font = new System.Drawing.Font("Arial", 8F);
            this.btOpenCOM.Location = new System.Drawing.Point(301, 76);
            this.btOpenCOM.Margin = new System.Windows.Forms.Padding(4);
            this.btOpenCOM.Name = "btOpenCOM";
            this.btOpenCOM.Size = new System.Drawing.Size(104, 29);
            this.btOpenCOM.TabIndex = 38;
            this.btOpenCOM.Text = "Open";
            this.btOpenCOM.Click += new System.EventHandler(this.btOpenCOM_Click);
            // 
            // cmbDataBit
            // 
            this.cmbDataBit.Font = new System.Drawing.Font("Arial", 8F);
            this.cmbDataBit.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cmbDataBit.Location = new System.Drawing.Point(227, 44);
            this.cmbDataBit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDataBit.Name = "cmbDataBit";
            this.cmbDataBit.Size = new System.Drawing.Size(63, 24);
            this.cmbDataBit.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 8F);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 21);
            this.label7.TabIndex = 46;
            this.label7.Text = "Connection Status";
            // 
            // labStopBit
            // 
            this.labStopBit.Font = new System.Drawing.Font("Arial", 8F);
            this.labStopBit.Location = new System.Drawing.Point(452, 25);
            this.labStopBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labStopBit.Name = "labStopBit";
            this.labStopBit.Size = new System.Drawing.Size(75, 19);
            this.labStopBit.TabIndex = 47;
            this.labStopBit.Text = "Stop Bit";
            this.labStopBit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labParity
            // 
            this.labParity.Font = new System.Drawing.Font("Arial", 8F);
            this.labParity.Location = new System.Drawing.Point(304, 25);
            this.labParity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labParity.Name = "labParity";
            this.labParity.Size = new System.Drawing.Size(131, 19);
            this.labParity.TabIndex = 48;
            this.labParity.Text = "Parity";
            this.labParity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labBaud
            // 
            this.labBaud.Font = new System.Drawing.Font("Arial", 8F);
            this.labBaud.Location = new System.Drawing.Point(115, 25);
            this.labBaud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labBaud.Name = "labBaud";
            this.labBaud.Size = new System.Drawing.Size(100, 19);
            this.labBaud.TabIndex = 49;
            this.labBaud.Text = "Baudrate";
            this.labBaud.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labDataBit
            // 
            this.labDataBit.Font = new System.Drawing.Font("Arial", 8F);
            this.labDataBit.Location = new System.Drawing.Point(227, 25);
            this.labDataBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDataBit.Name = "labDataBit";
            this.labDataBit.Size = new System.Drawing.Size(64, 19);
            this.labDataBit.TabIndex = 50;
            this.labDataBit.Text = "Data Bit";
            this.labDataBit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labPort
            // 
            this.labPort.Font = new System.Drawing.Font("Arial", 8F);
            this.labPort.Location = new System.Drawing.Point(8, 25);
            this.labPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPort.Name = "labPort";
            this.labPort.Size = new System.Drawing.Size(100, 19);
            this.labPort.TabIndex = 51;
            this.labPort.Text = "COM Port";
            this.labPort.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbBaud
            // 
            this.cmbBaud.Font = new System.Drawing.Font("Arial", 8F);
            this.cmbBaud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbBaud.Location = new System.Drawing.Point(113, 44);
            this.cmbBaud.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(100, 24);
            this.cmbBaud.TabIndex = 29;
            // 
            // cmbPort
            // 
            this.cmbPort.Font = new System.Drawing.Font("Arial", 8F);
            this.cmbPort.Location = new System.Drawing.Point(8, 44);
            this.cmbPort.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(99, 24);
            this.cmbPort.TabIndex = 28;
            this.cmbPort.Text = "COM6";
            this.cmbPort.SelectedIndexChanged += new System.EventHandler(this.cmbPort_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label5.Location = new System.Drawing.Point(57, -2);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(525, 42);
            this.label5.TabIndex = 51;
            this.label5.Text = "IO Simulation";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F);
            this.label1.Location = new System.Drawing.Point(36, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 52;
            this.label1.Text = "現在功率";
            // 
            // lb_p
            // 
            this.lb_p.AutoSize = true;
            this.lb_p.Font = new System.Drawing.Font("新細明體", 16F);
            this.lb_p.Location = new System.Drawing.Point(183, 205);
            this.lb_p.Name = "lb_p";
            this.lb_p.Size = new System.Drawing.Size(25, 27);
            this.lb_p.TabIndex = 53;
            this.lb_p.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 265);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 54;
            this.textBox1.Text = "1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 55;
            this.button1.Text = "增加功率 ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 34);
            this.button2.TabIndex = 56;
            this.button2.Text = "減少功率";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 16F);
            this.label2.Location = new System.Drawing.Point(224, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 27);
            this.label2.TabIndex = 57;
            this.label2.Text = "Kw";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 426);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_p);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCOMStatus);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Modbus_Slave_RTU_Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCOMStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCOMStatus;
        private System.Windows.Forms.ComboBox cmbStopBit;
        private System.Windows.Forms.Button btCloseCOM;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.Button btOpenCOM;
        private System.Windows.Forms.ComboBox cmbDataBit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labStopBit;
        private System.Windows.Forms.Label labParity;
        private System.Windows.Forms.Label labBaud;
        private System.Windows.Forms.Label labDataBit;
        private System.Windows.Forms.Label labPort;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_p;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}

