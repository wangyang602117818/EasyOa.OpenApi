using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Async;
using EasyOa.Common;
using EasyOa.OpenApi.Models;
using System.Text;

namespace EasyOa.OpenApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int a = 1, b = 0;
            int c = a/b;
            
            
           
            return View();
        }


    }

}
