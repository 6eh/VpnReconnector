namespace VpnReconnector
{
    internal class GetSettings
    {
        public static void GetSet(string subKey)
        {
            // Get Mail Settings
            AppSettings.Settings.MailSender = RegistryClass.RegRead(subKey, AppSettings.RegKeys.MailSenderKey);
            AppSettings.Settings.MailPass = CryptData.DecryptString(RegistryClass.RegRead(subKey, AppSettings.RegKeys.MailPassKey), MachineId.GetId());
            AppSettings.Settings.MailServer = RegistryClass.RegRead(subKey, AppSettings.RegKeys.MailServerKey);
            try { AppSettings.Settings.MailPort = Convert.ToInt32(RegistryClass.RegRead(subKey, AppSettings.RegKeys.MailPortKey)); } catch { }
            AppSettings.Settings.MailTo = RegistryClass.RegRead(subKey, AppSettings.RegKeys.MailToKey);
            AppSettings.Settings.MailSubject = RegistryClass.RegRead(subKey, AppSettings.RegKeys.MailSubjectKey);
            AppSettings.Settings.MailBody = RegistryClass.RegRead(subKey, AppSettings.RegKeys.MailBodyKey);
            AppSettings.Settings.CheckBoxMailStartup = RegistryClass.RegRead(subKey, AppSettings.RegKeys.CheckBoxMailStartupKey);

            // Get Vpn Settings
            AppSettings.Settings.PingHost = RegistryClass.RegRead(subKey, AppSettings.RegKeys.HostKey);
            try { AppSettings.Settings.PingTime = Convert.ToInt32(RegistryClass.RegRead(subKey, AppSettings.RegKeys.PingTimeKey)); } catch { }
            try { AppSettings.Settings.Timeout = Convert.ToInt32(RegistryClass.RegRead(subKey, AppSettings.RegKeys.TimeoutKey)); } catch { }
            AppSettings.Settings.ConnectionName = RegistryClass.RegRead(subKey, AppSettings.RegKeys.ConnectionNameKey);
            AppSettings.Settings.VPNLogin = RegistryClass.RegRead(subKey, AppSettings.RegKeys.VPNLoginKey);
            AppSettings.Settings.VPNPass = CryptData.DecryptString(RegistryClass.RegRead(subKey, AppSettings.RegKeys.VPNPasswordKey), MachineId.GetId());
            AppSettings.Settings.CheckBoxPing = RegistryClass.RegRead(subKey, AppSettings.RegKeys.CheckBoxPingKey);
            AppSettings.Settings.CheckBoxConnName = RegistryClass.RegRead(subKey, AppSettings.RegKeys.CheckBoxConnNameKey);
            AppSettings.Settings.CheckBoxVpnStartup = RegistryClass.RegRead(subKey, AppSettings.RegKeys.CheckBoxVpnStartupKey);
        }
    }
}
