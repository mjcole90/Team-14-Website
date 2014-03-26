using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewRequests()
        {
            return View();
        }

        public ActionResult CreateRequest()
        {
            return View();
        }

        public ActionResult AdHocRequest()
        {
            return View();
        }

        public ActionResult Settings()
        {
           
            return View();
        }

         public ActionResult Help()
        {
            return View();
        }
	}
}