namespace GPRO_QMS_SendSMS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.btnRegis = new System.Windows.Forms.Button();
            this.btnUnRegis = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnPortStatus = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveCom = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tmQuet = new System.Windows.Forms.Timer(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbsdt = new DevExpress.XtraEditors.LabelControl();
            this.lbb1 = new DevExpress.XtraEditors.LabelControl();
            this.lbb2 = new DevExpress.XtraEditors.LabelControl();
            this.lbb4 = new DevExpress.XtraEditors.LabelControl();
            this.lbb3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // btnRegis
            // 
            this.btnRegis.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRegis.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnRegis.Location = new System.Drawing.Point(16, 15);
            this.btnRegis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(316, 33);
            this.btnRegis.TabIndex = 0;
            this.btnRegis.Text = "Đăng ký khởi động cùng window";
            this.btnRegis.UseVisualStyleBackColor = true;
            this.btnRegis.Click += new System.EventHandler(this.btnRegis_Click);
            // 
            // btnUnRegis
            // 
            this.btnUnRegis.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUnRegis.Location = new System.Drawing.Point(16, 55);
            this.btnUnRegis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnRegis.Name = "btnUnRegis";
            this.btnUnRegis.Size = new System.Drawing.Size(316, 33);
            this.btnUnRegis.TabIndex = 1;
            this.btnUnRegis.Text = "Hủy đăng ký khởi động cùng window";
            this.btnUnRegis.UseVisualStyleBackColor = true;
            this.btnUnRegis.Click += new System.EventHandler(this.btnUnRegis_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(76, 103);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Comport";
            // 
            // btnPortStatus
            // 
            this.btnPortStatus.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnPortStatus.Image = global::GPRO_QMS_SendSMS.Properties.Resources.com_port_dis;
            this.btnPortStatus.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPortStatus.Location = new System.Drawing.Point(16, 95);
            this.btnPortStatus.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnPortStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPortStatus.Name = "btnPortStatus";
            this.btnPortStatus.Size = new System.Drawing.Size(52, 34);
            this.btnPortStatus.TabIndex = 5;
            // 
            // btnSaveCom
            // 
            this.btnSaveCom.Image = global::GPRO_QMS_SendSMS.Properties.Resources.if_15_Tick_16x16_173960;
            this.btnSaveCom.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSaveCom.Location = new System.Drawing.Point(280, 95);
            this.btnSaveCom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveCom.Name = "btnSaveCom";
            this.btnSaveCom.Size = new System.Drawing.Size(52, 34);
            this.btnSaveCom.TabIndex = 4;
            this.btnSaveCom.Click += new System.EventHandler(this.btnSaveCom_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(139, 100);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(16, 137);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(316, 28);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Gửi tin nhắn";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tmQuet
            // 
            this.tmQuet.Interval = 1000;
            this.tmQuet.Tick += new System.EventHandler(this.tmQuet_Tick);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 172);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(133, 17);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Số tin nhắn đã gửi : 0";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(195, 172);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(133, 17);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Số tin nhắn đã gửi : 0";
            // 
            // lbsdt
            // 
            this.lbsdt.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsdt.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbsdt.Location = new System.Drawing.Point(112, 196);
            this.lbsdt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(41, 17);
            this.lbsdt.TabIndex = 10;
            this.lbsdt.Text = "So DT";
            // 
            // lbb1
            // 
            this.lbb1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbb1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbb1.Location = new System.Drawing.Point(124, 221);
            this.lbb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbb1.Name = "lbb1";
            this.lbb1.Size = new System.Drawing.Size(19, 17);
            this.lbb1.TabIndex = 11;
            this.lbb1.Text = "B1";
            // 
            // lbb2
            // 
            this.lbb2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbb2.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbb2.Location = new System.Drawing.Point(189, 242);
            this.lbb2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbb2.Name = "lbb2";
            this.lbb2.Size = new System.Drawing.Size(19, 17);
            this.lbb2.TabIndex = 12;
            this.lbb2.Text = "B2";
            // 
            // lbb4
            // 
            this.lbb4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbb4.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbb4.Location = new System.Drawing.Point(104, 292);
            this.lbb4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbb4.Name = "lbb4";
            this.lbb4.Size = new System.Drawing.Size(19, 17);
            this.lbb4.TabIndex = 13;
            this.lbb4.Text = "B4";
            // 
            // lbb3
            // 
            this.lbb3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbb3.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbb3.Location = new System.Drawing.Point(164, 267);
            this.lbb3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbb3.Name = "lbb3";
            this.lbb3.Size = new System.Drawing.Size(19, 17);
            this.lbb3.TabIndex = 14;
            this.lbb3.Text = "B3";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 196);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(86, 17);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Số ĐT nhận : ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 220);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(100, 17);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Kết nối module :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(16, 292);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(83, 17);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Gửi tin nhắn :";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(16, 267);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(140, 17);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Cài đặt  số nhận sms : ";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(16, 242);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(165, 17);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "Cài đặt thông tin tin nhắn :";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 318);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lbb3);
            this.Controls.Add(this.lbb4);
            this.Controls.Add(this.lbb2);
            this.Controls.Add(this.lbb1);
            this.Controls.Add(this.lbsdt);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnPortStatus);
            this.Controls.Add(this.btnSaveCom);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnUnRegis);
            this.Controls.Add(this.btnRegis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "GPRO-QMS-SMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button btnRegis;
        private System.Windows.Forms.Button btnUnRegis;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSaveCom;
        private DevExpress.XtraEditors.SimpleButton btnPortStatus;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Timer tmQuet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lbsdt;
        private DevExpress.XtraEditors.LabelControl lbb1;
        private DevExpress.XtraEditors.LabelControl lbb2;
        private DevExpress.XtraEditors.LabelControl lbb4;
        private DevExpress.XtraEditors.LabelControl lbb3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}

