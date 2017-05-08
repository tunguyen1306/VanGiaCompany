using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
