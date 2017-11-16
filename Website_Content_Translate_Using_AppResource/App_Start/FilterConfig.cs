using System.Web;
using System.Web.Mvc;

namespace Website_Content_Translate_Using_AppResource
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}