using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyOa.Common;
using EasyOa.OpenApi.Exception;
using EasyOa.OpenApi.Models;

namespace EasyOa.OpenApi.Filters
{
    ///<summary>
    ///自定义mvc异常处理
    ///</summary>
    public class MyHandleErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //设置错误已处理
            filterContext.ExceptionHandled = true;
            //记录错误日志
            LogHelper.ErrorLog(filterContext.Exception);
            //返回
            filterContext.Result = new JsonResult()
                {
                    Data = new ResponseModel<string>()
                    {
                        url = HttpContext.Current.Request.Url.AbsoluteUri,
                        code = ErrorCode.System.server_exception,
                        msg = ErrorCode.System.server_exception.ToString(),
                        result = filterContext.Exception.Message
                    },
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
        }
    }
}