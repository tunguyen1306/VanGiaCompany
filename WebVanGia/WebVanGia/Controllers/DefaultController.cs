using PagedList;
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
        public ActionResult BlogList( int? page)
        {
            var pagenum = page ?? 1;
            var pageSize = 10;
            var data = from dataBlog in dbadmin.tbl_blog_tra
                       where dataBlog.id_company == 2 && dataBlog.status_blog_tra == 1
                       select dataBlog;
            return View(data.ToList().ToPagedList(pagenum, pageSize));
        }
        public ActionResult BlogList1( int? page)
        {
            var pagenum = page ?? 1;
            var pageSize = 10;
            var data = from dataBlog in dbadmin.tbl_blog_tra
                       where dataBlog.id_company == 2 && dataBlog.status_blog_tra==1
                       select dataBlog;
            return PartialView("BlogList", data.ToList().ToPagedList(pagenum, pageSize));
        }
        public ActionResult ProductList()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoadProducts()
        {
        //     public string vangia_img_id
        //{
        //    get
        //    {
        //        var regex = new Regex(@"^(?<id>\d+).*$");
        //        var match = regex.Match(originalFilepath);

        //        if (match.Success)
        //        {
        //            return match.Groups["id"].Value;
        //        }
        //        return null;
        //    }
        //}
        var urlLink = ConfigurationManager.AppSettings["domainvg"];

            var qrData = (from dataPro in dbadmin.web_vangia_project
                          join dataImg in dbadmin.tblSysPictures on dataPro.vangia_id_project equals dataImg.advert_id
                          where dataImg.position == 1 && dataPro.vangia_status_project == 1 && dataPro.vangia_typeid_project == 1 && dataPro.company==1
                          select new ProductsModel { tblProject = dataPro, tblPicture = dataImg }).ToList();
            return Json(qrData.Select(x => new
            {
                type = "image",
                image = urlLink + x.tblPicture.vangia_img_id + "/" + x.tblPicture.originalFilepath,
                thmb = urlLink + x.tblPicture.vangia_img_id + "/" + x.tblPicture.originalFilepath,
                alt = x.tblProject.vangia_name_project,
                title = x.tblProject.vangia_name_project,
                description = x.tblProject.vangia_content_project,
                titleColor = "#ffffff",
                descriptionColor = "#ffffff",
                link = "/Default/DetailProduct/" + x.tblProject.vangia_name_project.UrlFrendly() + "-" + x.tblProject.vangia_id_project
            }));
        }
        public ActionResult Travel()
        {
            return View();
        }
        public ActionResult Trade(int? page)
        {
            var pagenum = page ?? 1;
            var pageSize = 10;
            var qrData = (from dataPro in dbadmin.web_vangia_project
                          join dataImg in dbadmin.tblSysPictures on dataPro.vangia_id_project equals dataImg.advert_id
                          where dataImg.position == 1 && dataPro.vangia_status_project == 1 && dataPro.vangia_typeid_project == 1 && dataPro.company == 1
                          select new ProductsModel { tblProject = dataPro, tblPicture = dataImg }).ToList();
            return View(qrData.ToList().ToPagedList(pagenum, pageSize));
        }
        public ActionResult Trade1(int? page)
        {
            var pagenum = page ?? 1;
            var pageSize = 10;
            var qrData = (from dataPro in dbadmin.web_vangia_project
                          join dataImg in dbadmin.tblSysPictures on dataPro.vangia_id_project equals dataImg.advert_id
                          where dataImg.position == 1 && dataPro.vangia_status_project == 1 && dataPro.vangia_typeid_project == 1 && dataPro.company == 1
                          select new ProductsModel { tblProject = dataPro, tblPicture = dataImg }).ToList();
            return PartialView("Trade", qrData.ToList().ToPagedList(pagenum, pageSize));
        }
        public ActionResult DetailBlog(string id)
        {
            var id_ = int.Parse(id.Split('-').Last());
            return View(dbadmin.tbl_blog_tra.Where(x=>x.id_blog_tra== id_).FirstOrDefault());
        }
        public ActionResult DetailProduct(string id)
        {
            var id_ = int.Parse(id.Split('-').Last());
            ProductsModel pic = new ProductsModel
            {
               
                tblProject = dbadmin.web_vangia_project.Where(t => t.vangia_id_project == id_).FirstOrDefault(),
                tblListPicture = dbadmin.tblSysPictures.Where(x => x.advert_id == id_).ToList()
            };
            return View(pic);
        }
        [HttpPost]
        public ActionResult LoadSlider()
        {
           
            var urlLink = ConfigurationManager.AppSettings["domainvg"];
        

            var data = dbadmin.web_vangia_silde.OrderBy(x => x.vangia_order_silde).Where(x=>x.company==1).Take(10).ToList().Select(x=>new SliderModel
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
        public ActionResult test()
        {
            return View();
        }
       
    }
}
