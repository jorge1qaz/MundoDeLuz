using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace Business.Mailing
{
    public class Mailing
    {
        MailMessage mailMessage;
        SmtpClient smtpClient;
        bool errorMessage = false;
        static string message = "";
        public bool SendEmail(string emailBody, string toEmail, string subject)
        {
            try
            {
                mailMessage = new MailMessage("soporte.smartreport@gmail.com", toEmail); //jorgealcantara5a@gmail.com
                mailMessage.Body = emailBody;
                mailMessage.Subject = subject;
                mailMessage.From = new MailAddress("soporte.smartreport@gmail.com", "Soporte SmartReport", Encoding.UTF8);
                smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.Credentials = new System.Net.NetworkCredential()
                {
                    UserName = "soporte.smartreport@gmail.com",
                    Password = "3edc4rfvM@123"
                };
                smtpClient.EnableSsl = true;
                mailMessage.BodyEncoding = Encoding.UTF8;
                mailMessage.IsBodyHtml = true;
                mailMessage.Priority = MailPriority.Normal;
                mailMessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                smtpClient.Send(mailMessage);
                errorMessage = true;
            }
            catch (Exception e)
            {
                errorMessage = false;
            }
            return errorMessage;
        }
        public string GeneratePassword()
        {
            string newPassword = "";
            newPassword = Membership.GeneratePassword(12, 1);
            return newPassword;
        }
        public string messageToEmail(string idEncrypted, string key, string nameCostumer, Int16 typeMessage)
        {
            //switch (typeMessage)
            //{
            //    case 1: // Mensaje para cambiar contraseña
            //        message = "<div class='row'> <h2>Estimado(a) " + nameCostumer + " </h2><br><p>Se ha solicitado un cambio de contraseña para su cuenta de SmartReport, en caso de que no haya sido usted ignore este mensaje.</p><br><a style='text-decoration: none; cursor: pointer; line-height: 36px; padding: 0 2rem; color: #fff; background-color: #0275d8;border-color: #0275d8; display: inline-block; font-weight: 400; text-align: center; white-space: nowrap; vertical-align: middle; user-select:none; border: 1px solid transparent; font-size: 1rem; border-radius: .25rem; transition: all .2s ease-in-out; touch-action: manipulation;text-transform: none; overflow: visible; font-family: sans-serif; box-sizing: inherit;' href='" + seguridad.domain + "Perfiles/CambiarPassword?G89MbwRigyI7hulrDTK=" + idEncrypted + "&rdUczXSO0TR4ivfTogsgKLyXT=" + key + "'>Cambiar contraseña</a> </div>";
            //        break;
            //}
            return message;
        }
    }
}
