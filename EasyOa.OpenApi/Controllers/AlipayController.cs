using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Filters;
using EasyOa.Common.Alipay.DirectPay;
using EasyOa.Common.Properties;
using EasyOa.OpenApi.Models;

namespace EasyOa.OpenApi.Controllers
{
    /// <summary>
    /// 接受支付宝支付的参数
    /// </summary>
    public class AlipayController : ApiController
    {
        [HttpPost]
        public dynamic DirectPay(AliModelBase model)
        {

            return model;
        }
        [HttpPost]
        public Person M1(Person person)
        {
            return person;
        }
        [HttpGet]
        public Person M2(
            [StringLength(5, MinimumLength = 5, ErrorMessageResourceName = "StringLength", ErrorMessageResourceType = typeof(Resources))]
            string name,
            [Range(10, 100, ErrorMessageResourceName = "Range", ErrorMessageResourceType = typeof(Resources))]
            int? age)
        {
            ConfigurationFilterProvider actionDescriptor=new ConfigurationFilterProvider();
            HttpFilterCollection filterCollection = Configuration.Filters;
            
            return new Person() { Name = name, Age = age };
        }
    }

   
}
