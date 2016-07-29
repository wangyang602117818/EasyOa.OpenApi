using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;
using EasyOa.Common;
using EasyOa.OpenApi.Exception;

namespace EasyOa.OpenApi.Filters
{
    /// <summary>
    /// 自定义全局webapi异常处理,以后的代码里面就不需要写try catch捕获异常了
    /// </summary>
    public class MyExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            //记录错误日志，过滤掉由于参数没有通过验证而抛出的异常
            if (!actionExecutedContext.Exception.GetType().Name.Contains("ParamsException"))
            {
                LogHelper.ErrorLog(actionExecutedContext.Exception);
                throw new SysException(ErrorCode.System.server_exception, actionExecutedContext.Exception.Message);
            }
        }
    }
}