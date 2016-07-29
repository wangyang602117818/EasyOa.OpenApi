using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EasyOa.Common;

namespace EasyOa.OpenApi.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public dynamic M1()
        {
            var key = "78541561566322227854156156632222";
            
            var s1 = SymmetricEncryptHelper.AesEncode("123abc", key,false);
            var s2 = SymmetricEncryptHelper.AesDecode(s1, key,false);
            var str = SymmetricEncryptHelper.GenerateAESKey;
            return "加密：" + s1 + " 解密:" + s2;
        }
    }
}
