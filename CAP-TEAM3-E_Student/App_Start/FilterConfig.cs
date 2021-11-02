using System.Web;
using System.Web.Mvc;

namespace CAP_TEAM3_E_Student
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
