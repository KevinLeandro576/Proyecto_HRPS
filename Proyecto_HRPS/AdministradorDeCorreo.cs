using System.Net.Mail;
using System.Configuration;
//using System.Web.Configuration;
using System.Net.Configuration;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System;
using System.Collections.Generic;

namespace Proyecto_HRPS
{
    public class AdministradorDeCorreo
    {
        private string servidorDeSmtp;
        private string usuarioSmtp;
        private string passwordSmtp;
        private int puerto;

        public AdministradorDeCorreo(string servidor, string usuario, string password, int puerto)
        {
            this.servidorDeSmtp = servidor;
            this.usuarioSmtp = usuario;
            this.passwordSmtp = password;
            this.puerto = puerto;
        }

        public bool EnviarCorreo(string mensaje, string encabezado, string de, string alias, List<string> para)
        {
            try
            {
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress(de, alias, System.Text.Encoding.UTF8);//Correo de salida                
                foreach (string item in para)
                {
                    correo.To.Add(item); //Correo destino?
                }

                correo.Subject = encabezado; //Asunto
                correo.Body = mensaje; //Mensaje del correo

                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;

                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = true; //ESTABA EN FALSE Y SERVIA
                smtp.Host = servidorDeSmtp; //Host del servidor de correo
                smtp.Port = puerto; //Puerto de salida
                smtp.Credentials = new System.Net.NetworkCredential(usuarioSmtp, passwordSmtp);//Cuenta de correo
                smtp.EnableSsl = true;
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                smtp.EnableSsl = true;//True si el servidor de correo permite ssl

                smtp.Send(correo);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }
    }
}
