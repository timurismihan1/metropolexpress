using metropolexpress.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
        
    }
}