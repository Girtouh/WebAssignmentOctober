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

        T4DBWebAsEntities MyExperiencelist = new T4DBWebAsEntities();

        // List<Experiences> ExperienceList;

        //public HomeController()
        //{
        //    ExperienceList = new List<Experiences>();
        //    ExperienceList.Add(new Experiences() { Title = "Sommarresurs på dagis", WorkPlace = "Farsta Förskolor", TimeStarted = "2015", TimeEnded = "2015" });
        //}

        //Returning said views
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View(new T4DBWebAsEntities().Experiences.ToList());
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}