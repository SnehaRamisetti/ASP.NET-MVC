using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Net.Mime.MediaTypeNames;
using System.Web.UI.WebControls;

namespace HOL1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id)
        {
            if (id == null)
            {
                return Content("<h1>This is a demo of ContentResult</h1>");
            }
            else if (id.ToLower() == "plain")
            {
                return Content("<h1>This is a demo of ContentResult using plain</h1>","text/plain");
            }
            else if (id.ToLower() == "html")
            {
                return Content("<h1>This is a demo of ContentResult using html</h1>","text/html");
            }
            else if (id.ToLower() == "xml")
            {
                return Content("<h1>This is a demo of ContentResult using xml</h1>","text/xml");
            }
            return Content("Invalid content type");
        }
        public ActionResult DownloadFile()
        {
            if (!System.IO.File.Exists(@"D:\HOL2\flower.jpg"))
            {
                return Content("File to be downloaded not found");
            }
            return File(@"D:\HOL2\flower.jpg ", "image/jpg",
           "default.jpg");
        }
        public ActionResult Google()
        {
            return Redirect("http://www.MicrosoftEdge.com");
        }
        public ActionResult StartPage()
        {
            return RedirectToAction("Index", new { id = "xml" });
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }



    }
}