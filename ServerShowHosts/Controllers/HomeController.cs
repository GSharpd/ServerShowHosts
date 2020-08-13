using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Text;

namespace ServerShowHosts.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string path = @"C:/Windows/System32/drivers/etc/hosts";

            string readText = "";

            using (StreamReader file = new StreamReader(path))
            {
               readText = file.ReadToEnd();
            }

            return View(readText);
        }
    }
}