using Microsoft.Win32;
using QMS_System.Data.BLL;
using QMS_System.Data.Enum;
using QMS_System.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPRO_QMS_SendSMS
{
    public partial class frmMain : Form
    {
        List<SMSModel> sendArr = new List<SMSModel>();
        List<string> phones = new List<string>();
        string sendStr = string.Empty;
        AutoResetEvent receiveNow;
        bool IsFinishSend = true;
        Thread threadSend;
        int count = 0;

        string sdt = "", b1 = "", b2 = "", b3 = "", b4 = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRegis.Enabled = false;
            btnUnRegis.Enabled = false;
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (registryKey.GetValue("GPRO_QMS_SendSMS") == null)
                btnRegis.Enabled = true;
            else
                btnUnRegis.Enabled = true;
            foreach (string s in SerialPort.GetPortNames())
                comboBox1.Items.Add(s);

            InitComport();
        }

        private void InitComport()
        {
            var configs = BLLConfig.Instance.Gets();
            receiveNow = new AutoResetEvent(false);
            try
            {
                serialPort.PortName = GetConfigByCode(eConfigCode.ComName_SMS, configs);
                comboBox1.Text = serialPort.PortName;
                serialPort.BaudRate = Convert.ToInt32(GetConfigByCode(eConfigCode.BaudRate_SMS, configs));
                serialPort.DataBits = Convert.ToInt32(GetConfigByCode(eConfigCode.DataBits_SMS, configs));
                int parity = int.Parse(GetConfigByCode(eConfigCode.Parity_SMS, configs));
                switch (parity)
                {
                    case 0: serialPort.Parity = Parity.None; break;
                    case 1: serialPort.Parity = Parity.Odd; break;
                    case 2: serialPort.Parity = Parity.Even; break;
                    case 3: serialPort.Parity = Parity.Mark; break;
                    case 4: serialPort.Parity = Parity.Space; break;
                }

                int stopbit = int.Parse(GetConfigByCode(eConfigCode.StopBits_SMS, configs));
                switch (stopbit)
                {
                    case 0: serialPort.StopBits = StopBits.None; break;
                    case 1: serialPort.StopBits = StopBits.One; break;
                    case 2: serialPort.StopBits = StopBits.Two; break;
                    case 3: serialPort.StopBits = StopBits.OnePointFive; break;
                }
                try
                {
                    serialPort.ReadTimeout = 300;
                    serialPort.WriteTimeout = 300;
                    serialPort.Encoding = Encoding.GetEncoding("iso-8859-1");
                    serialPort.Open();
                    serialPort.DtrEnable = true;
                    serialPort.RtsEnable = true;

                    btnPortStatus.Image = global::GPRO_QMS_SendSMS.Properties.Resources.com_port;
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);

                    tmQuet.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi: không thể kết nối với cổng COM, Vui lòng thử cấu hình lại kết nối", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lấy thông tin Com bị lỗi.\n" + ex.Message, "Lỗi Com");
            }
        }

        private void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (e.EventType == SerialData.Chars)
                    receiveNow.Set();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ExecCommand(string command, int responseTimeout, string errorMessage)
        {
            try
            {
                serialPort.DiscardOutBuffer();
                serialPort.DiscardInBuffer();
                receiveNow.Reset();
                serialPort.Write(command + "\r");
                string input = ReadResponse(responseTimeout);
                if ((input.Length == 0) || ((!input.EndsWith("\r\n> ")) && (!input.EndsWith("\r\nOK\r\n"))))
                    throw new ApplicationException("No success message was received.");
                return input;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void sendMsg(string PhoneNo, string Message)
        {
            try
            {
                sdt = PhoneNo;
                string recievedData = ExecCommand("AT", 300, "No phone connected");
                b1 = "Ok";
                recievedData = ExecCommand("AT+CMGF=1", 300, "Failed to set message format.");
                b2 = "Ok";
                String command = "AT+CMGS=\"" + PhoneNo + "\"";
                recievedData = ExecCommand(command, 300, "Failed to accept phoneNo");
                b3 = "Ok";
                command = Message + char.ConvertFromUtf32(26) + "\r";
                recievedData = ExecCommand(command, 3000, "Failed to send message");
                b4 = "Ok";
                //3 seconds
                //   if (recievedData.Contains("OK"))

                //  else if (recievedData.Contains("ERROR"))
                //    isSend = false;
                //   labelControl2.Text = "Số tin nhắn đã gửi : " + count;
                Thread.Sleep(5000);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            count++;
        }

        public string ReadResponse(int timeout)
        {
            string buffer = string.Empty;
            try
            {
                do
                {
                    if (receiveNow.WaitOne(timeout, false))
                    {
                        string t = serialPort.ReadExisting();
                        buffer += t;
                    }
                    else
                    {
                        if (buffer.Length > 0)
                            throw new ApplicationException("Response received is incomplete.");
                        else
                            throw new ApplicationException("No data received from phone.");
                    }
                }
                while (!buffer.EndsWith("\r\nOK\r\n") && !buffer.EndsWith("\r\n> ") && !buffer.EndsWith("\r\nERROR\r\n"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return buffer;
        }

        #region Dang ky khoi dong cung window
        private void btnRegis_Click(object sender, EventArgs e)
        {
            RegisterStartWithWindow(true);
        }

        private void btnUnRegis_Click(object sender, EventArgs e)
        {
            RegisterStartWithWindow(false);
        }

        private void RegisterStartWithWindow(bool isChecked)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (isChecked)  // Đăng ký start up cùng Windows
            {
                registryKey.SetValue("GPRO_QMS_SendSMS", Directory.GetCurrentDirectory() + "\\GPRO_QMS_SendSMS.exe");
                btnRegis.Enabled = false;
                btnUnRegis.Enabled = true;
            }
            else  // Hủy đăng ký
            {
                registryKey.DeleteValue("GPRO_QMS_SendSMS");
                btnRegis.Enabled = true;
                btnUnRegis.Enabled = false;
            }
        }

        #endregion

        public string GetConfigByCode(string code, List<ConfigModel> configs)
        {
            if (configs != null && configs.Count > 0)
            {
                var obj = configs.FirstOrDefault(x => x.Code.Trim().ToUpper().Equals(code.Trim().ToUpper()));
                return obj != null ? obj.Value : string.Empty;
            }
            return string.Empty;
        }

        private void btnSaveCom_Click(object sender, EventArgs e)
        {
            BLLConfig.Instance.Update(eConfigCode.ComName_SMS, comboBox1.Text);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                sendMsg("0786399485", "Em gửi dc rồi anh Trí ơi. nhưng mà chưa xong nhé.hihihi"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int i = 0;
        private void tmQuet_Tick(object sender, EventArgs e)
        {
            var objs = BLLUserEvaluate.Instance.GetRequireSendSMS();
            if (objs.SMS.Count > 0)
            {
                //MessageBox.Show("co tin nhan");
                if (i == 0)
                {
                    phones.Clear();
                    phones.AddRange(objs.Phones);
                    i++;
                }
                sendArr.AddRange(objs.SMS);
                if (IsFinishSend)
                {
                    threadSend = new Thread(SendSMS);
                    threadSend.Start();
                }
            }
            labelControl2.Text = "Số tin nhắn đã gửi : " + count;
            labelControl3.Text = sendStr;
            lbsdt.Text = sdt;
            lbb1.Text = b1;
            lbb2.Text = b2;
            lbb3.Text = b3;
            lbb4.Text = b4;
        }

        private void SendSMS()
        {
            try
            {
                while (true)
                    if (sendArr.Count > 0)
                    {
                        if (IsFinishSend)
                        {
                            IsFinishSend = false;
                            ReadSound();
                        }
                    }
            }
            catch (Exception)
            {
            }
        }

        private void ReadSound()
        {
            try
            {
            Top:
                while (sendArr.Count > 0)
                {
                    for (int i = 0; i < phones.Count; i++)
                    {
                      //  MessageBox.Show(" gui tin nhan : "+ (sendArr[0].UserName + " " + sendArr[0].sms));
                        sendMsg(phones[i].Trim(), (sendArr[0].UserName + " " + sendArr[0].sms));
                    }

                    sendArr.Remove(sendArr[0]);
                    //  Thread.Sleep(5000);
                    if (sendArr.Count > 0)
                        goto Top;
                }
                //  sendStr = sendArr.Count.ToString();
                IsFinishSend = true;
                threadSend.Abort();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }

}
