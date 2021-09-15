using System.Web;
using System.Web.Mvc;

namespace DanielleBarnard8778SAPrg522
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
