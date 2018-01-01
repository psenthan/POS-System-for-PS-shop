using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Encryption;
using System.ServiceProcess;

namespace PS_Super_Market
{
    class MainClass
    {
        string connectionstring = @"Server=.\SQLEXPRESS; Database=PSSupermarket; Integrated Security=true; Connection Timeout=300; Min Pool Size=10; Max Pool Size=1000";
        public string Decrypt(string Input)
        {
            try
            {
                return Class1.Decrypt(Input);
            }
            catch
            {

                return null;
            }
        }
        public string Encrypt(string Input)
        {
            try
            {
                return Class1.Encrypt(Input);
            }
            catch
            {

                return null;
            }
        }
        public string TitleCase(string Text)
        {
            TextInfo txtinfo = new CultureInfo("en-US", false).TextInfo;
            return txtinfo.ToTitleCase(Text);
        }
        string message;
        public string MainFunction(string query, params object[] parameter)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                SqlCommand com = new SqlCommand(query, con);
                for (int i = 0; i < parameter.Length; i++)
                {
                    com.Parameters.Add(new SqlParameter("@" + i.ToString(), parameter[i]));
                }
                con.Open();
                com.ExecuteNonQuery();
                com.Dispose();
                con.Close();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

        }

        public string SendEmail(string ToEmail, string Body, string Subject)
        {
            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("nmssalman.finalproject@gmail.com");
                mail.To.Add(ToEmail);
                mail.Subject = Subject;
                mail.Body = Body;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("nmssalman.finalproject@gmail.com", "Salman1234");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                return "1";
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }

        }
        public string SendEmail(string ToEmail, string Body, string Subject, string AttachmentPath, string DisplayName, string CCEmail)
        {
            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("system.mmpawning@gmail.com", DisplayName);
                mail.To.Add(ToEmail);
                mail.CC.Add(CCEmail);
                mail.Subject = Subject;
                mail.Body = Body;
                if (AttachmentPath != "")
                {
                    Attachment attachment = new Attachment(AttachmentPath, MediaTypeNames.Application.Pdf);
                    mail.Attachments.Add(attachment);
                }
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("system.mmpawning@gmail.com", "abcd1111");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                return "1";
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }

        }
        public string SendEmail(string ToEmail, string Body, string Subject, string AttachmentPath, string DisplayName)
        {
            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("system.mmpawning@gmail.com", DisplayName);
                mail.To.Add(ToEmail);
                mail.Subject = Subject;
                mail.Body = Body;
                if (AttachmentPath != "")
                {
                    Attachment attachment = new Attachment(AttachmentPath, MediaTypeNames.Application.Pdf);
                    mail.Attachments.Add(attachment);
                }
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("system.mmpawning@gmail.com", "abcd1111");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                return "1";
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }

        }
        public void CrystalReportServer(ReportDocument rep)
        {
            ConnectionInfo crconinfo = new ConnectionInfo();
            crconinfo.ServerName = @".\SQLEXPRESS";
            crconinfo.DatabaseName = "PSSupermarket";
            crconinfo.IntegratedSecurity = true;
            Tables CrTables;
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();

            CrTables = rep.Database.Tables;

            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crconinfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }
        }
        public string CheckServiceStatus(string ServiceName)
        {
            ServiceController sc = new ServiceController(ServiceName);

            switch (sc.Status)
            {
                case ServiceControllerStatus.Running:
                    return "Running";
                case ServiceControllerStatus.Stopped:
                    sc.Start();
                    CheckServiceStatus(ServiceName);
                    return "Stopped";
                case ServiceControllerStatus.Paused:
                    return "Paused";
                    sc.Start();
                    CheckServiceStatus(ServiceName);
                case ServiceControllerStatus.StopPending:
                    return "Stopping";
                    sc.Start();
                    CheckServiceStatus(ServiceName);
                case ServiceControllerStatus.StartPending:
                    return "Starting";
                    sc.Start();
                    CheckServiceStatus(ServiceName);
                default:
                    return "Status Changing";
            }
        }
        public DataTable Search(string query)
        {
            DataTable table = new DataTable();

            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            table.Load(com.ExecuteReader());
            com.Dispose();
            con.Close();
            return table;
        }
        public DataTable SearchStoredProcedure(string StoredProcedure)
        {
            DataTable table = new DataTable();

            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand com = new SqlCommand(StoredProcedure, con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            table.Load(com.ExecuteReader());
            com.Dispose();
            con.Close();
            return table;
        }

        public string Insert(string query, params object[] parameter)
        {

            message = MainFunction(query, parameter);

            return message;
        }
        public string Update(string query, params object[] parameter)
        {

            message = MainFunction(query, parameter);

            return message;
        }
        public string Delete(string query, params object[] parameter)
        {

            message = MainFunction(query, parameter);

            return message;

        }
        public bool CheckInternet()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
