using System.Net;
using System.Net.Mail;

namespace VpnReconnector
{
    internal class Smtp
    {
        public static string SendMail(string mail_SenderMail, string mail_SenderName,string mail_SenderPass, 
            string mail_Port, string mail_SMTP, string mail_To, string mail_Subject, string mail_Body)
        {
            string ret = "";
            try
            {
                MailAddress from = new MailAddress(mail_SenderMail, mail_SenderName);
                MailAddress to = new MailAddress(mail_To);
                MailMessage m = new MailMessage(from, to);
                m.Subject = mail_Subject;
                m.Body = "<p>" + mail_Body + "</p>";
                m.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient(mail_SMTP, Convert.ToInt32(mail_Port));
                smtp.Credentials = new NetworkCredential(mail_SenderMail, mail_SenderPass);
                smtp.EnableSsl = true;
                smtp.Send(m);
                ret = "Mail has been sent (OK).";
            }
            catch (Exception ex)
            {
                ret = ex.Message;
            }
            return ret;
        }
    }
}
