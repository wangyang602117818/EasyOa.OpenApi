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
            ControllerDescriptor controller = new ReflectedAsyncControllerDescriptor(GetType());
            ActionDescriptor actionDescriptor = controller.FindAction(ControllerContext, "Index");
            IEnumerable<Filter> filters = FilterProviders.Providers.GetFilters(this.ControllerContext, actionDescriptor);
            
            return View();
        }


    }

}
