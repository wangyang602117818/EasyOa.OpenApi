using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Http.ModelBinding;

namespace EasyOa.OpenApi
{
    public class ValidateModelStateAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            List<string> valid_result = new List<string>();
            if (!actionContext.ModelState.IsValid)
            {
                foreach (KeyValuePair<string, ModelState> item in actionContext.ModelState)
                {
                    if (item.Value.Errors.Count > 0) valid_result.Add(item.Value.Errors[0].ErrorMessage);
                }
                throw new ApiException<ErrorCode.General>(ErrorCode.General.invalid_params, valid_result);
            }
        }
    }
}