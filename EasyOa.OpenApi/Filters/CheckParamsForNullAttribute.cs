using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using EasyOa.Common;
using EasyOa.Model;
using EasyOa.OpenApi.Models;

namespace EasyOa.OpenApi
{
    /// <summary>
    /// 检测方法的参数是否为null
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = true)]
    public class CheckParamsForNullAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            //访问日志，遇到不合法的Json格式，参数也会是null
            LogHelper.InfoLog("请求:[" + actionContext.Request.RequestUri.AbsoluteUri + "],参数:" + JsonSerializerHelper.Serialize(actionContext.ActionArguments));
            List<string> valid_result = CheckParams(actionContext.ActionArguments);
            if (valid_result.Count > 0)
            {
                throw new ParamsException(ErrorCode.General.invalid_params, valid_result);
            }
        }
        //传入请求参数，返回不合法的参数列表
        public List<string> CheckParams(Dictionary<string, object> dictionary)
        {
            List<string> invalid_params = new List<string>();
            foreach (KeyValuePair<string, object> keyValuePair in dictionary)
            {
                if (keyValuePair.Value == null) invalid_params.Add(keyValuePair.Key);
            }
            return invalid_params;
        }
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Response != null)
            {
                var httpContext = (actionExecutedContext.Response.Content as ObjectContent).Value;
                LogHelper.InfoLog("响应:" + JsonSerializerHelper.Serialize(httpContext));
            }
            //返回日志
            
        }
    }
}