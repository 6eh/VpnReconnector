using System.Net;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace VpnReconnector
{
    public partial class FormMain : Form
    {
        readonly Process VPNConnect = new();
        int timer3Void;
        bool CheckStarted = false;

        public FormMain()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetSettings.GetSet(this.ProductName);
            GetNewSettings();
            if (AppSettings.Settings.CheckBoxMailStartup == "1")
                timer1.Start();   // Check internet and send mail
            if (AppSettings.Settings.CheckBoxVpnStartup == "1")
            {
                label1.Text = "Checking VPN connection";
                StartCheck();   // Check connection by Connection Name or Host
            }
        }
        private void GetNewSettings()
        {
            timer3Void = AppSettings.Settings.Timeout;
            string command = @"/k rasdial " + AppSettings.Settings.ConnectionName + " " + AppSettings.Settings.VPNLogin + " " + AppSettings.Settings.VPNPass;
            VPNConnect.StartInfo = new ProcessStartInfo("cmd.exe", (string)command)
            {
                CreateNoWindow = true
            };
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings formSet = new();
            formSet.saveVpnSettingsButton.Click += FormSettings_SaveVpnButtonClick;   // FormSettings event handler (Save button clicked)
            formSet.ShowDialog();
        }

        private void FormSettings_SaveVpnButtonClick(object sender, EventArgs e)
        {
            if (CheckStarted == true)
            {
                StopCheck();
                VPNConnect.Close();
                GetNewSettings();
                StartCheck();
            }

            else if (CheckStarted == false)
            {
                StopCheck();
                VPNConnect.Close();
                GetNewSettings();
            }
        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VPNConnect.Close();
            Environment.Exit(0);
        }

        private void stopVPNCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopCheck();
        }

        private void startVPNCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartCheck();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void StopCheck()
        {
            CheckStarted = false;
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            startVPNCheckToolStripMenuItem.Enabled = true;
            stopVPNCheckToolStripMenuItem.Enabled = false;
            label1.Text = "...Stopped";
        }

        private void StartCheck()
        {
            CheckStarted = true;
            timer2.Start();
            startVPNCheckToolStripMenuItem.Enabled = false;
            stopVPNCheckToolStripMenuItem.Enabled = true;
            label1.Text = "Starting...";
        }

        public bool CheckForInternetConnection()
        {
            label1.Text = "Checking Internet on this PC...";
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckForInternetConnection())
            {
                if (Smtp.SendMail(AppSettings.Settings.MailSender, this.ProductName, AppSettings.Settings.MailPass,
                    AppSettings.Settings.MailPort.ToString(), AppSettings.Settings.MailServer, AppSettings.Settings.MailTo,
                    AppSettings.Settings.MailSubject, AppSettings.Settings.MailBody).Contains("(OK)"))
                {
                    label1.Text = "Mail has been sent.";
                    timer1.Stop();
                }
            }
        }

        //Check the connect
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = AppSettings.Settings.PingTime * 1000; // *1000 - convert to msec
            //Check by Connection Name
            if (AppSettings.Settings.CheckBoxConnName == "1")
            {
                NetworkInterface[] interfacesList = NetworkInterface.GetAllNetworkInterfaces();
                bool connStat = false;
                foreach (var v in interfacesList)
                {
                    //richTextBox1.Text = v.Name + " - " + v.NetworkInterfaceType + "\n";
                    if (v.Name == AppSettings.Settings.ConnectionName)
                    {
                        HaveVpn("VPN (" + v.Name + ") is connected");
                        connStat = true;
                    }
                }
                if (connStat == false)
                {
                    NoVPN("VPN (" + AppSettings.Settings.ConnectionName + ") is not connected");
                }
            }

            //Check by IP Ping
            else if (AppSettings.Settings.CheckBoxPing == "1")
            {
                Ping ping = new();
                string host = AppSettings.Settings.PingHost;
                try
                {
                    if (host != "")
                    {
                        PingReply reply = ping.Send(host);
                        if (reply.Status == IPStatus.Success)
                        {
                            HaveVpn("Host (" + AppSettings.Settings.PingHost + ") is available");
                        }
                        else
                        {
                            NoVPN("Host (" + AppSettings.Settings.PingHost + ") is not available");
                        }
                    }
                    else
                    {
                        label1.Text = "Host settings are empty,\ngo to settings!";
                    }
                }
                catch (Exception ex)
                {
                    StopCheck();
                    MessageBox.Show("Checking has been stopped!\n" + ex.Message + "\nConfigure the program.");
                }
            }
        }

        private void NoVPN(string message)
        {
            timer2.Stop();
            label1.Text = message;
            VPNStatusToolStripMenuItem.ForeColor = Color.Red;
            VPNStatusToolStripMenuItem.Text = message;
            VPNConnect.Start();
            timer3.Start();
        }
        private void HaveVpn(string message)
        {
            label1.Text = message;
            VPNStatusToolStripMenuItem.ForeColor = Color.Green;
            VPNStatusToolStripMenuItem.Text = message;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3Void--;
            label1.Text = "Recheck after " + timer3Void.ToString() + " sec.";
            if (timer3Void == 0)
            {
                timer3Void = AppSettings.Settings.Timeout;
                VPNConnect.Kill();
                label1.Text = "Reconnected...";
                timer3.Stop();
                timer2.Start();
            }
        }
    }
}