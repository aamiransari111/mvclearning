using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Filters;
namespace OdeToFood.Controllers
{
    [Log]
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //public string Index(string a)
        //{
        //    return "";
        //}
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Search(string name="french")
        {
            var message = Server.HtmlEncode(name);
            return Content(message);
            //return RedirectToAction("Index", "Home", new { name = name });
            //return Json(new { Message = message, Name = "Aamir" }, JsonRequestBehavior.AllowGet);
        }
        
 
        [HttpGet]
        public ActionResult Search()
        {
         
            return Content("Search!");
            //return RedirectToAction("Index", "Home", new { name = name });
            //return Json(new { Message = message, Name = "Aamir" }, JsonRequestBehavior.AllowGet);
        }
	}
}