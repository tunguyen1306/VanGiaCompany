using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebTravel
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
              name: "gioi-thieu",
              url: "nhu-trung/gioi-thieu",
              defaults: new { controller = "Home", action = "About" }
          );
            routes.MapRoute(
             name: "xay-dung",
             url: "nhu-trung/xay-dung",
             defaults: new { controller = "Home", action = "ProductList" }
         );
            routes.MapRoute(
                        name: "chi-tiet",
                        url: "nhu-trung/chi-tiet",
                        defaults: new { controller = "Home", action = "DetailProduct" }
                    );
            routes.MapRoute(
            name: "tinh-xay-dung",
            url: "xay-dung/tinh-xay-dung",
            defaults: new { controller = "Math", action = "Math" }
        );
            routes.MapRoute(
            name: "trang-chu",
            url: "nhu-trung/trang-chu",
            defaults: new { controller = "Home", action = "Index" }
        );
            routes.MapRoute(
         name: "thuong-mai",
         url: "nhu-trung/thuong-mai",
         defaults: new { controller = "Home", action = "Trade" }
     ); routes.MapRoute(
    name: "dich-vu",
    url: "nhu-trung/dich-vu",
    defaults: new { controller = "Home", action = "Travel" }
);
            routes.MapRoute(
      name: "blog",
      url: "nhu-trung/blog",
      defaults: new { controller = "Home", action = "BlogList" }
  );
            routes.MapRoute(
      name: "chi-tiet-blog",
      url: "nhu-trung/chi-tiet-blog",
      defaults: new { controller = "Home", action = "DetailBlog" }
  );
            routes.MapRoute(
                name: "Default1",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}