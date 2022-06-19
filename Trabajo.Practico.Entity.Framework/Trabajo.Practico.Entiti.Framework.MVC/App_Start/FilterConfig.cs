using System.Web;
using System.Web.Mvc;

namespace Trabajo.Practico.Entiti.Framework.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
