using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using EasyOa.Common;
using EasyOa.OpenApi.Models;
using System.Text;

namespace EasyOa.OpenApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            In();

            //LogDequeue<Person>.DoDequeue(ConsumeMessage);
            //LogHelper.MailLog(new System.Exception("sdsfds"));


            return View();
        }
        public bool ConsumeMessage(Person person)
        {
            string str = JsonSerializerHelper.Serialize(person);
            LogHelper.InfoLog(str);
            if (person.Age == 12)
            {

            }
            return true;
        }
        public void In()
        {
            List<Person> list = new List<Person>();
            for (int i = 0; i < 10; i++)
            {
                Person p = new Person()
               {
                   Age = i,
                   Name = "张三" + i
               };
                list.Add(p);
            }

            //Person1 p1 = new Person1()
            //    {
            //        A = 10,
            //        N = "asv"
            //    };
            foreach (Person person in list)
            {
                LogEnqueue.Enqueue(person);
            }
        }
    }

}
