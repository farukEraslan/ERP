using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;

namespace ERP.WebUI.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Quote(string nameSurname, string companyName, string customerEmail, string customerPhone, string message)
        {
            string messageBody = "Müşteri Adı Soyadı: " + nameSurname + "\n\n" + "Firma Adı: " + companyName + "\n\n" + "Müşteri E-Postası: " + customerEmail + "\n\n" + "Müşteri Telefonu: " + customerPhone + "\n\n" + "Bırakılan Mesaj: " + message + "\n\n" + "";

            Email(messageBody, customerEmail);

            return Redirect("~/Home/Quote");
        }

        public static void Email(string htmlString, string customerMail)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("frk.eraslan@hotmail.com");
                message.To.Add(new MailAddress("cemgulpinar@gurtasmakina.com"));
                message.Subject = "Teklif İsteği";
                message.IsBodyHtml = false; //to make message body as html  
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp-mail.outlook.com"; //for hotmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("frk.eraslan@hotmail.com", "3R4sl4n_f4r0k");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                throw new Exception("Bir Hata Oluştu!");
            }
        }
    }
}
