using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVanGia.Models;

namespace WebVanGia.Controllers
{
    public class MathController : Controller
    {
        DataAdminVanGiaEntities db = new DataAdminVanGiaEntities();
        //
        // GET: /Math/

        public ActionResult Math()
        {
            return View();
        }
       
       
    }
}
