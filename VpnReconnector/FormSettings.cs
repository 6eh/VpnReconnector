using System.Diagnostics;

namespace VpnReconnector
{
    public partial class FormSettings : Form
    {
        int RtbBodyMaxLength = 200;

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            richTextBoxBody.MaxLength = RtbBodyMaxLength;

            // Get Mail settings
            textBoxSender.Text = AppSettings.Settings.MailSender;
            textBoxSenderPass.Text = AppSettings.Settings.MailPass;
            textBoxSmtpServer.Text = AppSettings.Settings.MailServer;
            numericUpDownSmtpPort.Value = Convert.ToInt32(AppSettings.Settings.MailPort);
            textBoxRecipient.Text = AppSettings.Settings.MailTo;
            textBoxSubject.Text = AppSettings.Settings.MailSubject;
            richTextBoxBody.Text = AppSettings.Settings.MailBody;
            if (AppSettings.Settings.CheckBoxMailStartup == "1")
                checkBoxMailStartup.Checked = true;

            // Get Vpn settings
            textBoxPingHost.Text = AppSettings.Settings.PingHost;
            numericUpDownPingTime.Value = AppSettings.Settings.PingTime;
            numericUpDownTimeout.Value = AppSettings.Settings.Timeout;
            textBoxConnectionName.Text = AppSettings.Settings.ConnectionName;
            textBoxVpnLogin.Text = AppSettings.Settings.VPNLogin;
            textBoxVpnPass.Text = AppSettings.Settings.VPNPass;
            if (AppSettings.Settings.CheckBoxPing == "1")
                radioButtonPing.Checked = true;
            if (AppSettings.Settings.CheckBoxConnName == "1")
                radioButtonConnName.Checked = true;
            if (AppSettings.Settings.CheckBoxVpnStartup == "1")
                checkBoxVpnStartup.Checked = true;
        }

        private void richTextBoxBody_TextChanged(object sender, EventArgs e)
        {
            labelLength.Text = "Characters: " + (RtbBodyMaxLength - richTextBoxBody.TextLength).ToString();
        }

        private void buttonSendTestMail_Click(object sender, EventArgs e)
        {
            string mail_SenderMail = textBoxSender.Text;
            string mail_SenderName = this.ProductName;
            string mail_SenderPass = textBoxSenderPass.Text;
            string mail_SMTP = textBoxSmtpServer.Text;
            string mail_Port = numericUpDownSmtpPort.Value.ToString();
            string mail_To = textBoxRecipient.Text;
            string mail_Subject = "(Test) " + textBoxSubject.Text;
            string mail_Body = richTextBoxBody.Text;
            MessageBox.Show(Smtp.SendMail(mail_SenderMail, mail_SenderName, mail_SenderPass, mail_Port, mail_SMTP, mail_To, mail_Subject, mail_Body));

        }

        private void SaveMailSettingsButton_Click(object sender, EventArgs e)
        {
            string cbMailSturtup = "0";
            if (checkBoxMailStartup.Checked)
                cbMailSturtup = "1";

            RegistryClass.RegWrite(this.ProductName, AppSettings.RegKeys.MailSenderKey, textBoxSender.Text);
            RegistryClass.RegWrite(this.ProductName, AppSettings.RegKeys.MailPassKey, CryptData.EncryptString(textBoxSenderPass.Text, MachineId.GetId()));
            RegistryClass.RegWrite(this.ProductName, AppSettings.RegKeys.MailPortKey, numericUpDownSmtpPort.Value.ToString());
            RegistryClass.RegWrite(this.ProductName, AppSettings.RegKeys.MailServerKey, textBoxSmtpServer.Text);
            RegistryClass.RegWrite(this.ProductName, AppSettings.RegKeys.MailToKey, textBoxRecipient.Text);
            RegistryClass.RegWrite(this.ProductName, AppSettings.RegKeys.MailSubjectKey, textBoxSubject.Text);
            RegistryClass.RegWrite(this.ProductName, AppSettings.RegKeys.MailBodyKey, richTextBoxBody.Text);
            RegistryClass.RegWrite(this.ProductName, AppSettings.RegKeys.CheckBoxMailStartupKey, cbMailSturtup);
        }

        private void saveVpnSettingsButton_Click(object sender, EventArgs e)
        {

            string rbPingStatus = "0";
            if (radioButtonPing.Checked)
                rbPingStatus = "1";

            string rbConnNameStatus = "0";
            if (radioButtonConnName.Checked)
                rbConnNameStatus = "1";

            string cbVpnStartup = "0";
            if (checkBoxVpnStartup.Checked)
                cbVpnStartup = "1";

            RegistryClass.RegWrite(this.ProductName, AppSettings.RegKeys.HostKey, textBoxPingHost.Text);
            RegistryClass.RegWrite(this.ProductName, AppSettings.RegKeys.ConnectionNameKey, textBoxConnectionName.Text);
            RegistryClass.RegWrite(this.ProductName, AppSettings.RegKeys.PingTimeKey, numericUpDownPingTime.Value.ToString());
            RegistryClass.RegWrite(this.ProductName, AppSettings.RegKeys.TimeoutKey, numericUpDownTimeout.Value.ToString());
            RegistryClass.RegWrite(this.ProductName, AppSettings.RegKeys.VPNLoginKey, textBoxVpnLogin.Text);
            RegistryClass.RegWrite(this.ProductName, AppSettings.RegKeys.VPNPasswordKey, CryptData.EncryptString(textBoxVpnPass.Text, MachineId.GetId()));
            RegistryClass.RegWrite(this.ProductName, AppSettings.RegKeys.CheckBoxPingKey, rbPingStatus);
            RegistryClass.RegWrite(this.ProductName, AppSettings.RegKeys.CheckBoxConnNameKey, rbConnNameStatus);
            RegistryClass.RegWrite(this.ProductName, AppSettings.RegKeys.CheckBoxVpnStartupKey, cbVpnStartup);

            // update settings
            GetSettings.GetSet(this.ProductName);
        }

        private void linkLabelOpenNCPA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ProcessStartInfo process = new("NCPA.cpl");
                process.UseShellExecute = true;
                Process.Start(process);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
