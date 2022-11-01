using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
namespace Routecardapi.Models
{
    public class SendEmail
    {
        Um_accesslayer daccess = new Um_accesslayer();
        MailMessage smtpobject = new MailMessage();
        SmtpClient smtp = new SmtpClient();
        public string SendEmailTemplate(EmailSendingMaster model, string html, string Host, string from, int Port, string DeliveryMethod, bool EnableSsl)
        {
            try
            {
                MailMessage mail = EmailSendingMtd(model.CC, model.BCC, model.TO, html, model.SUBJECT, from);
                SmtpClient kcplsmtpclient = EmailCredentials(Host, Port, EnableSsl);
                kcplsmtpclient.Send(mail);
                return "success";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                smtpobject.Dispose();
                smtp.Dispose();
            }
        }

        private static MailMessage EmailSendingMtd(string CC, string BCC, string To, string html, string Subject, string from)
        {
            MailMessage mail = new MailMessage();
            MailAddress fromAddress = new MailAddress(from, "KIRLOKAR CHILLERS PVT LTD.");
            mail.To.Add(To);
            mail.CC.Add(CC); //mail.Bcc.Add(BCC);
            mail.Subject = Subject;
            mail.IsBodyHtml = true;
            mail.Body = html;
            mail.From = fromAddress;
            return mail;
        }
        public void EmailSending(string filter, SqlConnection conn, SqlCommand cmd, out EmailCredentials cred, out EmailSendingMaster sendingdetails)
        {
            cred = new EmailCredentials();
            sendingdetails = new EmailSendingMaster();
            DataTable dtable = new DataTable();
            SqlCommand cmmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SP_PullEmailCredentials";
            cmd.Parameters.AddWithValue("@filter", filter);
            cmd.CommandType = CommandType.StoredProcedure;
            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                while (sdr.Read())
                {
                    cred.HOST = sdr["HOST"].ToString();
                    cred.FROM = sdr["FROM"].ToString();
                    cred.HOST = sdr["HOST"].ToString();
                    cred.Port = sdr["Port"].ToString();
                    cred.EnableSsl = Convert.ToBoolean(sdr["EnableSsl"].ToString());
                }
                sdr.NextResult();
                while (sdr.Read())
                {
                    {
                        sendingdetails.CC = sdr["CC"].ToString();
                        sendingdetails.TO = sdr["TO"].ToString();
                        sendingdetails.BCC = sdr["BCC"].ToString();
                        sendingdetails.DESCRIPTION = sdr["DESCRIPTION"].ToString();
                        sendingdetails.SUBJECT = sdr["SUBJECT"].ToString();
                        //Updated on 17-08-2020
                        sendingdetails.EMAIL_TO = sdr["EMAIL_TO"].ToString();
                        sendingdetails.REGARDS = sdr["REGARDS"].ToString();
                        sendingdetails.EMAIL_FROM = sdr["EMAIL_FROM"].ToString();
                        sendingdetails.FOOTER = sdr["FOOTER"].ToString();
                    }
                }
            }
        }
        private static SmtpClient EmailCredentials(string Host, int Port, bool EnableSsl)
        {
            SmtpClient kcplsmtpclient = new SmtpClient();
            kcplsmtpclient.Host = Host;
            kcplsmtpclient.Port = Port;
            kcplsmtpclient.EnableSsl = EnableSsl;
            kcplsmtpclient.DeliveryMethod = SmtpDeliveryMethod.Network;
            return kcplsmtpclient;
        }
    }
}