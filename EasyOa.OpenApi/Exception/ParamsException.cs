using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using EasyOa.Common;
namespace EasyOa.OpenApi
{
    public class ParamsException<T> : HttpResponseException
    {
        public ParamsException(T code, List<string> param_name, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
            : base(statusCode)
        {
            var error = new
                  {
                      url = HttpContext.Current.Request.Url.AbsoluteUri,
                      code = code,
                      msg = code + "[" + string.Join(",", param_name) + "]",
                  };
            Response.Content = new StringContent(JsonSerializerHelper.Serialize(error));
        }
    }
}