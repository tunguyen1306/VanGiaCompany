using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using WebVanGia.Models;

namespace WebVanGia.Controllers
{
    public class DefaultController : Controller
    {
        private DataAdminVanGiaEntities dbadmin = new DataAdminVanGiaEntities();
        //
        // GET: /Default/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult BlogList()
        {
            return View();
        }
        public ActionResult ProductList()
        {
            return View();
        }
        public ActionResult DetailBlog(string id)
        {
            var id_ = int.Parse(id.Split('-').Last());
            return View(dbadmin.tbl_blog_tra.Where(x=>x.id_blog_tra== id_).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult LoadSlider()
        {
           
            var urlLink = ConfigurationManager.AppSettings["domainvg"];
        

            var data = dbadmin.web_vangia_silde.OrderBy(x => x.vangia_order_silde).Take(10).ToList().Select(x=>new SliderModel
            {
                vangia_id_silde=x.vangia_id_silde,
                vangia_img_silde=x.vangia_img_silde,
                vangia_name_silde=x.vangia_name_silde,
                vangia_noidung_silde=x.vangia_noidung_silde,
                vangia_tomtat_silde=x.vangia_tomtat_silde

            });

            return Json(data.Select(x => new
            {
                type = "image",
                image = urlLink + x.vangia_img_id + "/" + x.vangia_img_silde,
                thmb = urlLink + x.vangia_img_id + "/" + x.vangia_img_silde,
                alt = x.vangia_name_silde,
                title = x.vangia_name_silde,
                description = x.vangia_noidung_silde,
                titleColor = "#ffffff",
                descriptionColor = "#ffffff"
            }));
        }
        public string addLink(string link)
        {
            var data = "";

            data = link.Split('_')[0];

            return data;

        }
    }
}
