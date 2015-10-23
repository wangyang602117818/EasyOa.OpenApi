using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using EasyOa.OpenApi.Filters;

namespace EasyOa.OpenApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //这是专门处理mvc异常的，webapi无效
            filters.Add(new MyHandleErrorAttribute()); 
            //这是专门处理webapi异常的
            GlobalConfiguration.Configuration.Filters.Add(new MyExceptionFilterAttribute());
            //这是检测参数是否为null的
            GlobalConfiguration.Configuration.Filters.Add(new CheckParamsForNullAttribute());
            //这是检测ModelState的
            GlobalConfiguration.Configuration.Filters.Add(new ValidateModelStateAttribute());
        }
    }
}