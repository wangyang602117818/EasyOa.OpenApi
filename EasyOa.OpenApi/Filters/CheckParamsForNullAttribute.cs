using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

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
            List<string> valid_result = CheckParams(actionContext.ActionArguments);
            if (valid_result.Count > 0)
            {
                throw new ApiException<ErrorCode.General>(ErrorCode.General.invalid_params, valid_result);
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
    }
}