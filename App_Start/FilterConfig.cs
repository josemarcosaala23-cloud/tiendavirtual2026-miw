using System.Web;
using System.Web.Mvc;

namespace TiendaVirtual_MarkJoseph_2026
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
