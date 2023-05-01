using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vegan_Market.Models;

namespace Vegan_Market.Controllers
{
    public class HomeController : Controller
    {
        Aslan_Commerce_vtEntities vegan_entities = new Aslan_Commerce_vtEntities(); 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Homepage()
        {
            return View();
        }
        public ActionResult categoryList()
        {
            var categories = vegan_entities.Category.ToList();
            return PartialView(categories);
        }
        public ActionResult aboutUs()
        {
            return View();
        }
         public ActionResult Faq()
        {
            return View();
        }

        public ActionResult stores()
        {
            return View();
        }
        public ActionResult contactUs()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
       

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}