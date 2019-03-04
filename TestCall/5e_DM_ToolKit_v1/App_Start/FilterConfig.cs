using System.Web;
using System.Web.Mvc;

namespace _5e_DM_ToolKit_v1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
