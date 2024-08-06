using System.Web;
using System.Web.Mvc;

namespace web_dat_phong_khach_san
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
