using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTravel.Models;

namespace WebTravel.Controllers
{
    public class MathController : Controller
    {
        WebTravelEntities db = new WebTravelEntities();
        //
        // GET: /Math/

        public ActionResult Math()
        {
            return View();
        }
       
       
    }
}
