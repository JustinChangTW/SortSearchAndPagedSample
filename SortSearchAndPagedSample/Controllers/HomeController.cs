using SortSearchAndPagedSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SortSearchAndPagedSample.Controllers
{
    public class HomeController : Controller
    {
        private SkillTreeHomewrok _db;

        public HomeController()
        {
            _db = new SkillTreeHomewrok();
        }

        public ActionResult Index()
        {
            ViewData.Model = _db.AccountBook.ToList();
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