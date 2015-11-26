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
        public dynamic DirectPay(AliModelBase model)
        {

            return model;
        }
        [HttpPost]
        public Person M1(Person person)
        {
            return person;
        }
    }
}
