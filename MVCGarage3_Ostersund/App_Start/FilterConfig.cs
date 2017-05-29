using System.Web;
using System.Web.Mvc;

namespace MVCGarage3_Ostersund
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
