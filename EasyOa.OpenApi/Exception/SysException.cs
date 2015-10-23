using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using EasyOa.Common;

namespace EasyOa.OpenApi.Exception
{
    public class SysException<T> : HttpResponseException
    {
        public SysException(T code, string msg, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
            : base(statusCode)
        {
            var error = new
            {
                url = HttpContext.Current.Request.Url.AbsoluteUri,
                code = code,
                msg = code.ToString(),
                extra = msg
            };
            Response.Content = new StringContent(JsonSerializerHelper.Serialize(error));
        }
    }
}