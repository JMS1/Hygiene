using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HygieneMVC.Models;
using PagedList;


namespace HygieneMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ////test
            //HygieneContext db = new HygieneContext();
            //IQueryable<Restaurant> Res = null;
            //var rest = db.Restaurants.ToList();
            //Res = rest.AsQueryable();

            return View();
        }

        public ActionResult SearchResults(string restaurantString, int? page)
        {
            HygieneContext db = new HygieneContext();

            IQueryable<Restaurant> Res = null;
            var rest = db.Restaurants.ToList();
            //Res = rest.AsQueryable();

            if (String.IsNullOrEmpty(restaurantString))
            {
                restaurantString = "No value passed";
            }



            ViewData["SearchTerm"] = restaurantString;



            var restaurantList = rest.Where(s => s.BusinessName.ToLower().Contains(restaurantString.ToLower())).ToList();
            //var restaurantList = qy.Where(s => s.BusinessName.ToLower().Contains(restaurantString.ToLower())).ToList();
            var filteredRes = restaurantList.AsQueryable();

            ViewData["Count"] = restaurantList.Count();

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            ViewBag.search = restaurantString;

            return View(filteredRes.ToPagedList(pageNumber, pageSize));

        }

        public ActionResult Details(int? id)
        {
            HygieneContext db = new HygieneContext();
            var qy = db.Restaurants.Single(r => r.FHRSID == id);
            ViewData["Longitude"] = qy.Longitude;
            ViewData["Latitude"] = qy.Latitude;
            ViewData["BusinessName"] = qy.BusinessName;

            return View(qy);
        }
    }
}