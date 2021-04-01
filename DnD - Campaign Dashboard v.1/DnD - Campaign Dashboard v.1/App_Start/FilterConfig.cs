using System.Web;
using System.Web.Mvc;

namespace DnD___Campaign_Dashboard_v._1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
