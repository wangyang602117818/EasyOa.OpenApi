using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EasyOa.Model;
using EasyOa.OpenApi.Models;
using EasyOa.OpenApi.Properties;
using Newtonsoft.Json;

namespace EasyOa.OpenApi.Controllers
{
    public class FileController : ApiController
    {
        [HttpGet]
        public dynamic Md5(
            [StringLength(32, ErrorMessage = "参数必须32")]
            string code)
        {
            var str = ModelState;

            return JsonConvert.SerializeObject(str);
        }
    }
}
