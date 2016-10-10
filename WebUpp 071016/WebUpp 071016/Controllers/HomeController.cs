using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUpp_071016.Models;

namespace WebUpp_071016.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        List<Experience> ExperienceList;

        public HomeController()
        {
            ExperienceList = new List<Experience>();
            ExperienceList.Add(new Experience() { Title = "Sommarresurs på dagis", WorkPlace = "Farsta Förskolor", TimeStarted = "2015", TimeEnded = "2015" });
        }

        //Returning said views
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View(ExperienceList);
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}