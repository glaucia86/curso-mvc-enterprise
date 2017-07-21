using System.Web;
using System.Web.Mvc;
using GL.AppEnterprise.Infra.CrossCutting.Filters;

namespace GL.AppEnterprise.UI.Mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new GlobalErrorHandler());
        }
    }
}
