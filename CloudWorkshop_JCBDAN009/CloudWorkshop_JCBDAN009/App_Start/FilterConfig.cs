using System.Web;
using System.Web.Mvc;

namespace CloudWorkshop_JCBDAN009
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
