using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
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
        [HttpPost]
        public Person M2(
            [MinLength(3, ErrorMessage = "长度不够")]
            string name,
             [Range(10, 20, ErrorMessage = "范围错误")]
            int? age)
        {
            return new Person() { Name = name, Age = age };
        }

    }

   
}
