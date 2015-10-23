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
    /// 自定义全局webapi异常处理
    /// </summary>
    public class MyExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            //记录错误日志
            LogHelper.ErrorLog(actionExecutedContext.Exception);
            throw new SysException<ErrorCode.System>(ErrorCode.System.server_exception, actionExecutedContext.Exception.Message);
        }
    }
}