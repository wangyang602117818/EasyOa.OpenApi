using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyOa.Common;
using EasyOa.OpenApi.Exception;

namespace EasyOa.OpenApi.Filters
{
    /// <summary>
    /// 自定义mvc异常处理
    /// </summary>
    public class MyHandleErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //设置错误已处理
            filterContext.ExceptionHandled = true;
            //记录错误日志
            LogHelper.InfoLog(filterContext.Exception.ToString());
            //返回
            filterContext.Result =
                new SysException<ErrorCode.System>(ErrorCode.System.server_exception, filterContext.Exception.Message)
                    .Content;
        }
    }
}