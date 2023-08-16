using metropolexpress.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace metropolexpress.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("hakkimizda")]
        public ActionResult About()
        {
            return View();
        }
        [Route("iletisim")]
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult SendEmail(ContactMailModel model)
        {
            MailMessage m = new MailMessage();
            m.From = new MailAddress("iletisim@metropolexpress.com.tr");
            m.To.Add("info@metropolexpress.com.tr");
            m.Subject = model.Subject;
            m.Body = "Merahba! İletişim sayfasından gelen Bir Mesajınız var.Aşşağıda Bilgileri bulabilirsiniz; <br>" + model.NameSurname + "<br>" + model.Email + "<br>" + model.Phone + "<br>" + model.Subject + "<br>" + model.Message;
            m.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient();
            
            smtpClient.Credentials = new NetworkCredential("iletisim@metropolexpress.com.tr", "23pFm4gd58giSzR");
            smtpClient.Port = 587;
            smtpClient.Host = "metropolexpress.com.tr";
            smtpClient.EnableSsl = true;


            try
            {
                smtpClient.Send(m);
                return Json(true);
            }
            catch (Exception)
            {
                return Json(false);
            }

            
        }
        public ActionResult SendServiceRequest(ServiceRequestModel model)
        {
            MailMessage m = new MailMessage();
            m.From = new MailAddress("iletisim@metropolexpress.com.tr");
            m.To.Add("info@metropolexpress.com.tr");
            m.Subject = model.Phone;
            m.Body = "Merahba! Ana sayfada bulunan nakliye hizmeti bölümünden bir mesajınız var. Aşağıda bilgileri bulabilirsiniz; <br>" + model.FullName + "<br>" + model.Email + "<br>" + model.Phone + "<br>";
            m.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient();

            smtpClient.Credentials = new NetworkCredential("iletisim@metropolexpress.com.tr", "23pFm4gd58giSzR");
            smtpClient.Port = 587;
            smtpClient.Host = "metropolexpress.com.tr";
            smtpClient.EnableSsl = true;


            try
            {
                smtpClient.Send(m);
                return Json(true);
            }
            catch (Exception)
            {
                return Json(false);
            }

        }

        [Route("kurumsal-tasima")]
        public ActionResult CorporateTransport()
        {
            return View();
        }
        [Route("ozel-ambalajlama-ve-paketleme")]
        public ActionResult CustomPackaging()
        {
            return View();
        }

        [Route("evden-eve-tasima")]
        public ActionResult HomeToHomeTransport()
        {
            return View();
        }

        [Route("asansorlu-tasima")]
        public ActionResult LiftCarrying()
        {
            return View();
        }
        [Route("esya-depolama")]
        public ActionResult StorageOfGoods()
        {
            return View();
        }
        [Route("galeri")]
        public ActionResult Gallery()
        {
            return View();
        }


    }
}
