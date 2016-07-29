using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using EasyOa.Common;
using EasyOa.OpenApi.Models;

namespace EasyOa.OpenApi.Exception
{
    public class SysException : HttpResponseException
    {
        public SysException(Enum code, string msg, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
            : base(statusCode)
        {
            var error = new ResponseModel<string>()
                {
                    url = HttpContext.Current.Request.Url.AbsoluteUri,
                    code = code,
                    msg = code.ToString(),
                    result = msg
                };
            Response.Content = new StringContent(JsonSerializerHelper.Serialize(error));
        }
    }
}