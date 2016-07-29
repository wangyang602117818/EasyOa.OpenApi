using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using EasyOa.Common;
using EasyOa.OpenApi.Models;

namespace EasyOa.OpenApi
{
    public class ParamsException : HttpResponseException
    {
        public ParamsException(Enum code, List<string> param_name, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
            : base(statusCode)
        {
            var error = new ResponseModel<string>()
                  {
                      url = HttpContext.Current.Request.Url.AbsoluteUri,
                      code = code,
                      msg = code.ToString() + "[" + string.Join(",", param_name).Trim(',') + "]",
                      result = ""
                  };
            Response.Content = new StringContent(JsonSerializerHelper.Serialize(error));
        }
    }
}