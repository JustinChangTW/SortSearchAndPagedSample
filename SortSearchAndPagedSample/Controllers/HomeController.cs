using PagedList;
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

        public ActionResult Index(int? page)
        {
            //ViewData.Model = _db.AccountBook.ToList();
            var pageIndex = page.HasValue ? page.Value < 1 ? 1 : page.Value : 1; //目前第N頁
            var pageSize = 10; //每一頁列數

            ViewData.Model = _db.AccountBook
                .OrderByDescending(d => d.Dateee)
                .ToPagedList(pageIndex, pageSize); //使用PageList提供的擴充方法

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