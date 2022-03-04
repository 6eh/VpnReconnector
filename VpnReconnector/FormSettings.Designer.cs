namespace VpnReconnector
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.vpnSettingsTabPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxVpnStartup = new System.Windows.Forms.CheckBox();
            this.textBoxVpnPass = new System.Windows.Forms.TextBox();
            this.textBoxVpnLogin = new System.Windows.Forms.TextBox();
            this.textBoxConnectionName = new System.Windows.Forms.TextBox();
            this.numericUpDownTimeout = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPingTime = new System.Windows.Forms.NumericUpDown();
            this.textBoxPingHost = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.linkLabelOpenNCPA = new System.Windows.Forms.LinkLabel();
            this.labelConnectionName = new System.Windows.Forms.Label();
            this.labelConnectionTimeout = new System.Windows.Forms.Label();
            this.labelPingTime = new System.Windows.Forms.Label();
            this.labelPingAdress = new System.Windows.Forms.Label();
            this.radioButtonPing = new System.Windows.Forms.RadioButton();
            this.radioButtonConnName = new System.Windows.Forms.RadioButton();
            this.saveVpnSettingsButton = new System.Windows.Forms.Button();
            this.mailSettingsTabPage = new System.Windows.Forms.TabPage();
            this.checkBoxMailStartup = new System.Windows.Forms.CheckBox();
            this.buttonSendTestMail = new System.Windows.Forms.Button();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelMailBody = new System.Windows.Forms.Label();
            this.label3MailSubject = new System.Windows.Forms.Label();
            this.labelMailTo = new System.Windows.Forms.Label();
            this.labelMailPort = new System.Windows.Forms.Label();
            this.labelMailServer = new System.Windows.Forms.Label();
            this.labelMailPass = new System.Windows.Forms.Label();
            this.labelMailSender = new System.Windows.Forms.Label();
            this.numericUpDownSmtpPort = new System.Windows.Forms.NumericUpDown();
            this.richTextBoxBody = new System.Windows.Forms.RichTextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxRecipient = new System.Windows.Forms.TextBox();
            this.textBoxSmtpServer = new System.Windows.Forms.TextBox();
            this.textBoxSenderPass = new System.Windows.Forms.TextBox();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.SaveMailSettingsButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.vpnSettingsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingTime)).BeginInit();
            this.mailSettingsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSmtpPort)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.vpnSettingsTabPage);
            this.tabControl1.Controls.Add(this.mailSettingsTabPage);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(324, 407);
            this.tabControl1.TabIndex = 0;
            // 
            // vpnSettingsTabPage
            // 
            this.vpnSettingsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.vpnSettingsTabPage.Controls.Add(this.pictureBox1);
            this.vpnSettingsTabPage.Controls.Add(this.checkBoxVpnStartup);
            this.vpnSettingsTabPage.Controls.Add(this.textBoxVpnPass);
            this.vpnSettingsTabPage.Controls.Add(this.textBoxVpnLogin);
            this.vpnSettingsTabPage.Controls.Add(this.textBoxConnectionName);
            this.vpnSettingsTabPage.Controls.Add(this.numericUpDownTimeout);
            this.vpnSettingsTabPage.Controls.Add(this.numericUpDownPingTime);
            this.vpnSettingsTabPage.Controls.Add(this.textBoxPingHost);
            this.vpnSettingsTabPage.Controls.Add(this.labelPass);
            this.vpnSettingsTabPage.Controls.Add(this.labelLogin);
            this.vpnSettingsTabPage.Controls.Add(this.linkLabelOpenNCPA);
            this.vpnSettingsTabPage.Controls.Add(this.labelConnectionName);
            this.vpnSettingsTabPage.Controls.Add(this.labelConnectionTimeout);
            this.vpnSettingsTabPage.Controls.Add(this.labelPingTime);
            this.vpnSettingsTabPage.Controls.Add(this.labelPingAdress);
            this.vpnSettingsTabPage.Controls.Add(this.radioButtonPing);
            this.vpnSettingsTabPage.Controls.Add(this.radioButtonConnName);
            this.vpnSettingsTabPage.Controls.Add(this.saveVpnSettingsButton);
            this.vpnSettingsTabPage.Location = new System.Drawing.Point(4, 24);
            this.vpnSettingsTabPage.Name = "vpnSettingsTabPage";
            this.vpnSettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.vpnSettingsTabPage.Size = new System.Drawing.Size(316, 379);
            this.vpnSettingsTabPage.TabIndex = 0;
            this.vpnSettingsTabPage.Text = "VPN Settings";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VpnReconnector.Properties.Resources.VpnReconnector1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxVpnStartup
            // 
            this.checkBoxVpnStartup.AutoSize = true;
            this.checkBoxVpnStartup.Location = new System.Drawing.Point(6, 57);
            this.checkBoxVpnStartup.Name = "checkBoxVpnStartup";
            this.checkBoxVpnStartup.Size = new System.Drawing.Size(241, 19);
            this.checkBoxVpnStartup.TabIndex = 22;
            this.checkBoxVpnStartup.Text = "Run VPN check when this program starts";
            this.checkBoxVpnStartup.UseVisualStyleBackColor = true;
            // 
            // textBoxVpnPass
            // 
            this.textBoxVpnPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVpnPass.Location = new System.Drawing.Point(153, 231);
            this.textBoxVpnPass.Name = "textBoxVpnPass";
            this.textBoxVpnPass.PasswordChar = '*';
            this.textBoxVpnPass.Size = new System.Drawing.Size(154, 23);
            this.textBoxVpnPass.TabIndex = 21;
            this.textBoxVpnPass.UseSystemPasswordChar = true;
            // 
            // textBoxVpnLogin
            // 
            this.textBoxVpnLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVpnLogin.Location = new System.Drawing.Point(153, 207);
            this.textBoxVpnLogin.Name = "textBoxVpnLogin";
            this.textBoxVpnLogin.Size = new System.Drawing.Size(154, 23);
            this.textBoxVpnLogin.TabIndex = 20;
            // 
            // textBoxConnectionName
            // 
            this.textBoxConnectionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConnectionName.Location = new System.Drawing.Point(153, 155);
            this.textBoxConnectionName.Name = "textBoxConnectionName";
            this.textBoxConnectionName.Size = new System.Drawing.Size(154, 23);
            this.textBoxConnectionName.TabIndex = 19;
            // 
            // numericUpDownTimeout
            // 
            this.numericUpDownTimeout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownTimeout.Location = new System.Drawing.Point(153, 130);
            this.numericUpDownTimeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownTimeout.Name = "numericUpDownTimeout";
            this.numericUpDownTimeout.Size = new System.Drawing.Size(154, 23);
            this.numericUpDownTimeout.TabIndex = 18;
            // 
            // numericUpDownPingTime
            // 
            this.numericUpDownPingTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownPingTime.Location = new System.Drawing.Point(153, 106);
            this.numericUpDownPingTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPingTime.Name = "numericUpDownPingTime";
            this.numericUpDownPingTime.Size = new System.Drawing.Size(154, 23);
            this.numericUpDownPingTime.TabIndex = 17;
            // 
            // textBoxPingHost
            // 
            this.textBoxPingHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPingHost.Location = new System.Drawing.Point(153, 81);
            this.textBoxPingHost.Name = "textBoxPingHost";
            this.textBoxPingHost.Size = new System.Drawing.Size(154, 23);
            this.textBoxPingHost.TabIndex = 16;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(6, 233);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(83, 15);
            this.labelPass.TabIndex = 15;
            this.labelPass.Text = "VPN Password";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(6, 209);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(63, 15);
            this.labelLogin.TabIndex = 14;
            this.labelLogin.Text = "VPN Login";
            // 
            // linkLabelOpenNCPA
            // 
            this.linkLabelOpenNCPA.AutoSize = true;
            this.linkLabelOpenNCPA.Location = new System.Drawing.Point(153, 181);
            this.linkLabelOpenNCPA.Name = "linkLabelOpenNCPA";
            this.linkLabelOpenNCPA.Size = new System.Drawing.Size(154, 15);
            this.linkLabelOpenNCPA.TabIndex = 10;
            this.linkLabelOpenNCPA.TabStop = true;
            this.linkLabelOpenNCPA.Text = "Open Network Connections";
            this.linkLabelOpenNCPA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOpenNCPA_LinkClicked);
            // 
            // labelConnectionName
            // 
            this.labelConnectionName.AutoSize = true;
            this.labelConnectionName.Location = new System.Drawing.Point(6, 157);
            this.labelConnectionName.Name = "labelConnectionName";
            this.labelConnectionName.Size = new System.Drawing.Size(102, 15);
            this.labelConnectionName.TabIndex = 9;
            this.labelConnectionName.Text = "Connection name";
            // 
            // labelConnectionTimeout
            // 
            this.labelConnectionTimeout.AutoSize = true;
            this.labelConnectionTimeout.Location = new System.Drawing.Point(6, 132);
            this.labelConnectionTimeout.Name = "labelConnectionTimeout";
            this.labelConnectionTimeout.Size = new System.Drawing.Size(142, 15);
            this.labelConnectionTimeout.TabIndex = 8;
            this.labelConnectionTimeout.Text = "Connection timeout (sec)";
            // 
            // labelPingTime
            // 
            this.labelPingTime.AutoSize = true;
            this.labelPingTime.Location = new System.Drawing.Point(6, 108);
            this.labelPingTime.Name = "labelPingTime";
            this.labelPingTime.Size = new System.Drawing.Size(117, 15);
            this.labelPingTime.TabIndex = 4;
            this.labelPingTime.Text = "Ping every time (sec)";
            // 
            // labelPingAdress
            // 
            this.labelPingAdress.AutoSize = true;
            this.labelPingAdress.Location = new System.Drawing.Point(6, 83);
            this.labelPingAdress.Name = "labelPingAdress";
            this.labelPingAdress.Size = new System.Drawing.Size(117, 15);
            this.labelPingAdress.TabIndex = 3;
            this.labelPingAdress.Text = "Ping host name or IP";
            // 
            // radioButtonPing
            // 
            this.radioButtonPing.AutoSize = true;
            this.radioButtonPing.Location = new System.Drawing.Point(6, 32);
            this.radioButtonPing.Name = "radioButtonPing";
            this.radioButtonPing.Size = new System.Drawing.Size(164, 19);
            this.radioButtonPing.TabIndex = 2;
            this.radioButtonPing.TabStop = true;
            this.radioButtonPing.Text = "Check connection by ping";
            this.radioButtonPing.UseVisualStyleBackColor = true;
            // 
            // radioButtonConnName
            // 
            this.radioButtonConnName.AutoSize = true;
            this.radioButtonConnName.Location = new System.Drawing.Point(6, 7);
            this.radioButtonConnName.Name = "radioButtonConnName";
            this.radioButtonConnName.Size = new System.Drawing.Size(234, 19);
            this.radioButtonConnName.TabIndex = 1;
            this.radioButtonConnName.TabStop = true;
            this.radioButtonConnName.Text = "Check connection by connection status";
            this.radioButtonConnName.UseVisualStyleBackColor = true;
            // 
            // saveVpnSettingsButton
            // 
            this.saveVpnSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveVpnSettingsButton.Location = new System.Drawing.Point(6, 342);
            this.saveVpnSettingsButton.Name = "saveVpnSettingsButton";
            this.saveVpnSettingsButton.Size = new System.Drawing.Size(304, 29);
            this.saveVpnSettingsButton.TabIndex = 0;
            this.saveVpnSettingsButton.Text = "Save";
            this.saveVpnSettingsButton.UseVisualStyleBackColor = true;
            this.saveVpnSettingsButton.Click += new System.EventHandler(this.saveVpnSettingsButton_Click);
            // 
            // mailSettingsTabPage
            // 
            this.mailSettingsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.mailSettingsTabPage.Controls.Add(this.checkBoxMailStartup);
            this.mailSettingsTabPage.Controls.Add(this.buttonSendTestMail);
            this.mailSettingsTabPage.Controls.Add(this.labelLength);
            this.mailSettingsTabPage.Controls.Add(this.labelMailBody);
            this.mailSettingsTabPage.Controls.Add(this.label3MailSubject);
            this.mailSettingsTabPage.Controls.Add(this.labelMailTo);
            this.mailSettingsTabPage.Controls.Add(this.labelMailPort);
            this.mailSettingsTabPage.Controls.Add(this.labelMailServer);
            this.mailSettingsTabPage.Controls.Add(this.labelMailPass);
            this.mailSettingsTabPage.Controls.Add(this.labelMailSender);
            this.mailSettingsTabPage.Controls.Add(this.numericUpDownSmtpPort);
            this.mailSettingsTabPage.Controls.Add(this.richTextBoxBody);
            this.mailSettingsTabPage.Controls.Add(this.textBoxSubject);
            this.mailSettingsTabPage.Controls.Add(this.textBoxRecipient);
            this.mailSettingsTabPage.Controls.Add(this.textBoxSmtpServer);
            this.mailSettingsTabPage.Controls.Add(this.textBoxSenderPass);
            this.mailSettingsTabPage.Controls.Add(this.textBoxSender);
            this.mailSettingsTabPage.Controls.Add(this.SaveMailSettingsButton);
            this.mailSettingsTabPage.Location = new System.Drawing.Point(4, 24);
            this.mailSettingsTabPage.Name = "mailSettingsTabPage";
            this.mailSettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mailSettingsTabPage.Size = new System.Drawing.Size(316, 379);
            this.mailSettingsTabPage.TabIndex = 1;
            this.mailSettingsTabPage.Text = "Mail Settings";
            // 
            // checkBoxMailStartup
            // 
            this.checkBoxMailStartup.AutoSize = true;
            this.checkBoxMailStartup.Location = new System.Drawing.Point(6, 7);
            this.checkBoxMailStartup.Name = "checkBoxMailStartup";
            this.checkBoxMailStartup.Size = new System.Drawing.Size(234, 19);
            this.checkBoxMailStartup.TabIndex = 38;
            this.checkBoxMailStartup.Text = "Send an email when this program starts";
            this.checkBoxMailStartup.UseVisualStyleBackColor = true;
            // 
            // buttonSendTestMail
            // 
            this.buttonSendTestMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendTestMail.Location = new System.Drawing.Point(6, 298);
            this.buttonSendTestMail.Name = "buttonSendTestMail";
            this.buttonSendTestMail.Size = new System.Drawing.Size(141, 29);
            this.buttonSendTestMail.TabIndex = 37;
            this.buttonSendTestMail.Text = "Send a test email";
            this.buttonSendTestMail.UseVisualStyleBackColor = true;
            this.buttonSendTestMail.Click += new System.EventHandler(this.buttonSendTestMail_Click);
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelLength.ForeColor = System.Drawing.Color.Gray;
            this.labelLength.Location = new System.Drawing.Point(223, 298);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(88, 15);
            this.labelLength.TabIndex = 36;
            this.labelLength.Text = "Characters: 200";
            // 
            // labelMailBody
            // 
            this.labelMailBody.AutoSize = true;
            this.labelMailBody.Location = new System.Drawing.Point(6, 194);
            this.labelMailBody.Name = "labelMailBody";
            this.labelMailBody.Size = new System.Drawing.Size(66, 15);
            this.labelMailBody.TabIndex = 35;
            this.labelMailBody.Text = "Email Body";
            // 
            // label3MailSubject
            // 
            this.label3MailSubject.AutoSize = true;
            this.label3MailSubject.Location = new System.Drawing.Point(6, 159);
            this.label3MailSubject.Name = "label3MailSubject";
            this.label3MailSubject.Size = new System.Drawing.Size(78, 15);
            this.label3MailSubject.TabIndex = 34;
            this.label3MailSubject.Text = "Email Subject";
            // 
            // labelMailTo
            // 
            this.labelMailTo.AutoSize = true;
            this.labelMailTo.Location = new System.Drawing.Point(6, 134);
            this.labelMailTo.Name = "labelMailTo";
            this.labelMailTo.Size = new System.Drawing.Size(141, 15);
            this.labelMailTo.TabIndex = 33;
            this.labelMailTo.Text = "Recipient\'s email Address";
            // 
            // labelMailPort
            // 
            this.labelMailPort.AutoSize = true;
            this.labelMailPort.Location = new System.Drawing.Point(6, 109);
            this.labelMailPort.Name = "labelMailPort";
            this.labelMailPort.Size = new System.Drawing.Size(62, 15);
            this.labelMailPort.TabIndex = 32;
            this.labelMailPort.Text = "SMTP Port";
            // 
            // labelMailServer
            // 
            this.labelMailServer.AutoSize = true;
            this.labelMailServer.Location = new System.Drawing.Point(6, 84);
            this.labelMailServer.Name = "labelMailServer";
            this.labelMailServer.Size = new System.Drawing.Size(72, 15);
            this.labelMailServer.TabIndex = 31;
            this.labelMailServer.Text = "SMTP Server";
            // 
            // labelMailPass
            // 
            this.labelMailPass.AutoSize = true;
            this.labelMailPass.Location = new System.Drawing.Point(6, 59);
            this.labelMailPass.Name = "labelMailPass";
            this.labelMailPass.Size = new System.Drawing.Size(136, 15);
            this.labelMailPass.TabIndex = 30;
            this.labelMailPass.Text = "Sender\'s email Password";
            // 
            // labelMailSender
            // 
            this.labelMailSender.AutoSize = true;
            this.labelMailSender.Location = new System.Drawing.Point(5, 34);
            this.labelMailSender.Name = "labelMailSender";
            this.labelMailSender.Size = new System.Drawing.Size(128, 15);
            this.labelMailSender.TabIndex = 29;
            this.labelMailSender.Text = "Sender\'s email Address";
            // 
            // numericUpDownSmtpPort
            // 
            this.numericUpDownSmtpPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownSmtpPort.Location = new System.Drawing.Point(175, 107);
            this.numericUpDownSmtpPort.Maximum = new decimal(new int[] {
            65635,
            0,
            0,
            0});
            this.numericUpDownSmtpPort.Name = "numericUpDownSmtpPort";
            this.numericUpDownSmtpPort.Size = new System.Drawing.Size(130, 23);
            this.numericUpDownSmtpPort.TabIndex = 28;
            // 
            // richTextBoxBody
            // 
            this.richTextBoxBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxBody.Location = new System.Drawing.Point(6, 212);
            this.richTextBoxBody.MaxLength = 200;
            this.richTextBoxBody.Name = "richTextBoxBody";
            this.richTextBoxBody.Size = new System.Drawing.Size(304, 83);
            this.richTextBoxBody.TabIndex = 27;
            this.richTextBoxBody.Text = "";
            this.richTextBoxBody.TextChanged += new System.EventHandler(this.richTextBoxBody_TextChanged);
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSubject.Location = new System.Drawing.Point(175, 157);
            this.textBoxSubject.MaxLength = 50;
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(130, 23);
            this.textBoxSubject.TabIndex = 26;
            // 
            // textBoxRecipient
            // 
            this.textBoxRecipient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRecipient.Location = new System.Drawing.Point(175, 132);
            this.textBoxRecipient.Name = "textBoxRecipient";
            this.textBoxRecipient.Size = new System.Drawing.Size(130, 23);
            this.textBoxRecipient.TabIndex = 25;
            // 
            // textBoxSmtpServer
            // 
            this.textBoxSmtpServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSmtpServer.Location = new System.Drawing.Point(175, 82);
            this.textBoxSmtpServer.Name = "textBoxSmtpServer";
            this.textBoxSmtpServer.Size = new System.Drawing.Size(130, 23);
            this.textBoxSmtpServer.TabIndex = 23;
            // 
            // textBoxSenderPass
            // 
            this.textBoxSenderPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSenderPass.Location = new System.Drawing.Point(175, 57);
            this.textBoxSenderPass.Name = "textBoxSenderPass";
            this.textBoxSenderPass.PasswordChar = '*';
            this.textBoxSenderPass.Size = new System.Drawing.Size(130, 23);
            this.textBoxSenderPass.TabIndex = 22;
            this.textBoxSenderPass.UseSystemPasswordChar = true;
            // 
            // textBoxSender
            // 
            this.textBoxSender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSender.Location = new System.Drawing.Point(175, 32);
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.Size = new System.Drawing.Size(130, 23);
            this.textBoxSender.TabIndex = 17;
            // 
            // SaveMailSettingsButton
            // 
            this.SaveMailSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveMailSettingsButton.Location = new System.Drawing.Point(6, 342);
            this.SaveMailSettingsButton.Name = "SaveMailSettingsButton";
            this.SaveMailSettingsButton.Size = new System.Drawing.Size(304, 29);
            this.SaveMailSettingsButton.TabIndex = 0;
            this.SaveMailSettingsButton.Text = "Save";
            this.SaveMailSettingsButton.UseVisualStyleBackColor = true;
            this.SaveMailSettingsButton.Click += new System.EventHandler(this.SaveMailSettingsButton_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 420);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSettings";
            this.Text = "VPN Reconnector Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.vpnSettingsTabPage.ResumeLayout(false);
            this.vpnSettingsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingTime)).EndInit();
            this.mailSettingsTabPage.ResumeLayout(false);
            this.mailSettingsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSmtpPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage vpnSettingsTabPage;
        private TabPage mailSettingsTabPage;
        private Button SaveMailSettingsButton;
        private TextBox textBoxVpnPass;
        private TextBox textBoxVpnLogin;
        private TextBox textBoxConnectionName;
        private NumericUpDown numericUpDownTimeout;
        private NumericUpDown numericUpDownPingTime;
        private TextBox textBoxPingHost;
        private Label labelPass;
        private Label labelLogin;
        private LinkLabel linkLabelOpenNCPA;
        private Label labelConnectionName;
        private Label labelConnectionTimeout;
        private Label labelPingTime;
        private Label labelPingAdress;
        private RadioButton radioButtonPing;
        private RadioButton radioButtonConnName;
        private TextBox textBoxSenderPass;
        private TextBox textBoxSender;
        private TextBox textBoxSmtpServer;
        private TextBox textBoxRecipient;
        private RichTextBox richTextBoxBody;
        private TextBox textBoxSubject;
        private NumericUpDown numericUpDownSmtpPort;
        private Label labelLength;
        private Label labelMailBody;
        private Label label3MailSubject;
        private Label labelMailTo;
        private Label labelMailPort;
        private Label labelMailServer;
        private Label labelMailPass;
        private Label labelMailSender;
        public Button saveVpnSettingsButton;
        private Button buttonSendTestMail;
        private CheckBox checkBoxVpnStartup;
        private CheckBox checkBoxMailStartup;
        private PictureBox pictureBox1;
    }
}