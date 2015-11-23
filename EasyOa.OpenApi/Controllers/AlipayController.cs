using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EasyOa.Common.Alipay.DirectPay;
using EasyOa.OpenApi.Models;

namespace EasyOa.OpenApi.Controllers
{
    /// <summary>
    /// 接受支付宝支付的参数
    /// </summary>
    public class AlipayController : ApiController
    {
        [HttpPost]
        public string DirectPay([FromBody]AliRequestModel aliRequestModel)
        {

            return "";
        }
        [HttpPost]
        public Person Ma(Person person)
        {

            return person;
        }
    }
}
