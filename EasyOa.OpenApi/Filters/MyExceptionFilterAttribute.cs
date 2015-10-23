using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace EasyOa.OpenApi.Filters
{
    /// <summary>
    /// 自定义全局webapi异常处理
    /// </summary>
    public class MyExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            string str = "";
            base.OnException(actionExecutedContext);
        }
    }
}