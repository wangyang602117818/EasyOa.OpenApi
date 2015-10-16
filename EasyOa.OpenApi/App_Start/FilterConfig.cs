using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace EasyOa.OpenApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            GlobalConfiguration.Configuration.Filters.Add(new CheckParamsForNullAttribute());
            GlobalConfiguration.Configuration.Filters.Add(new ValidateModelStateAttribute());
        }
    }
}