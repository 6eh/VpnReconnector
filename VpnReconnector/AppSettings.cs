namespace VpnReconnector
{
    internal class AppSettings
    {
        public static class Settings
        {
            public static string? PingHost { get; set; }
            public static int PingTime { get; set; } = 1;
            public static int Timeout { get; set; } = 30;
            public static string? ConnectionName { get; set; }
            public static string? VPNLogin { get; set; }
            public static string? VPNPass { get; set; }
            public static string? CheckBoxPing { get; set; }
            public static string? CheckBoxConnName { get; set; }
            public static string? CheckBoxVpnStartup { get; set; }
            public static string? CheckBoxMailStartup { get; set; }
            public static string? MailSender { get; set; }
            public static string? MailPass { get; set; }
            public static int MailPort { get; set; } = 25;
            public static string? MailServer { get; set; }
            public static string? MailTo { get; set; }
            public static string? MailSubject { get; set; }
            public static string? MailBody { get; set; }

    }

        public static class RegKeys
        {
            public readonly static string SoftwareKey = "Software";
            public readonly static string HostKey = "host";
            public readonly static string PingTimeKey = "ptm";
            public readonly static string TimeoutKey = "tm";
            public readonly static string ConnectionNameKey = "cn";
            public readonly static string VPNLoginKey = "vl";
            public readonly static string VPNPasswordKey = "vp";
            public readonly static string CheckBoxPingKey = "cbp";
            public readonly static string CheckBoxConnNameKey = "cbh";
            public readonly static string CheckBoxVpnStartupKey = "cvs";
            public readonly static string CheckBoxMailStartupKey = "cms";
            public readonly static string MailSenderKey = "ms";
            public readonly static string MailPassKey = "mp";
            public readonly static string MailPortKey = "mprt";
            public readonly static string MailServerKey = "msrv";
            public readonly static string MailToKey = "mto";
            public readonly static string MailSubjectKey = "msbj";
            public readonly static string MailBodyKey = "mb";
        }
    }
}
