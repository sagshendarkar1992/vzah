using System.IO;
using System.Net.Mail;
using System.Web;

namespace ModelPortal
{
    public class EmailHelper
    {
        public static void Send(string emailID, string code)
        {
            StreamReader reader = new StreamReader(HttpContext.Current.Server.MapPath("~/Template/ALaramBlow.html"));
            SmtpClient smtp = new SmtpClient();
            string readFile = reader.ReadToEnd();
            string myString = "";
            myString = readFile;
            myString = myString.Replace("$$EmailID$$", emailID);
            myString = myString.Replace("$$Code$$", code);
            MailMessage mail = new MailMessage();
            mail.To.Add(emailID);
            mail.Subject = "ALaram BLow";
            mail.Body = myString.ToString();
            mail.IsBodyHtml = true;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            smtp.Send(mail);
        }
    }
}
