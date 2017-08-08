using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebVanGia
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
              name: "gioi-thieu",
              url: "van-gia/gioi-thieu",
              defaults: new { controller = "Default", action = "About" }
          );
            routes.MapRoute(
             name: "xay-dung",
             url: "van-gia/xay-dung",
             defaults: new { controller = "Default", action = "ProductList" }
         );
            routes.MapRoute(
                        name: "chi-tiet",
                        url: "van-gia/chi-tiet",
                        defaults: new { controller = "Default", action = "DetailProduct" }
                    );
            routes.MapRoute(
            name: "tinh-xay-dung",
            url: "xay-dung/tinh-xay-dung",
            defaults: new { controller = "Math", action = "Math" }
        );
            routes.MapRoute(
            name: "trang-chu",
            url: "van-gia/trang-chu",
            defaults: new { controller = "Default", action = "Index" }
        );
            routes.MapRoute(
         name: "thuong-mai",
         url: "van-gia/thuong-mai",
         defaults: new { controller = "Default", action = "Trade" }
     ); routes.MapRoute(
    name: "dich-vu",
    url: "van-gia/dich-vu",
    defaults: new { controller = "Default", action = "Travel" }
);
            routes.MapRoute(
      name: "blog",
      url: "van-gia/blog",
      defaults: new { controller = "Default", action = "BlogList" }
  );
            routes.MapRoute(
      name: "chi-tiet-blog",
      url: "van-gia/chi-tiet-blog",
      defaults: new { controller = "Default", action = "DetailBlog" }
  );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}