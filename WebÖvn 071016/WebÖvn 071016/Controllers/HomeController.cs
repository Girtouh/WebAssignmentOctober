using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebÖvn_071016.Models;

namespace WebÖvn_071016.Controllers
{
    public class HomeController : Controller
    {
        //Fejkar koppling till en DB för Experience


        List<Experience> MyExperienceList;

        public HomeController()
        {
            MyExperienceList = new List<Experience>();
            MyExperienceList.Add(new Experience() { Title = "Målare", Description = "Morfars hus", Period = "2016" });
            MyExperienceList.Add(new Experience() { Title = "Tryckare", Description = "Tryckeri", Period = "2015" });
            MyExperienceList.Add(new Experience() { Title = "Uteliggare", Description = "Slussen huligan", Period = "1971" });

        }

        //======================================

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View(MyExperienceList);
        }
    }
}