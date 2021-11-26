using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class SecondController : Controller
    {
        // GET: Second
        public ActionResult Index()
        {
            return View();
        }
        public ContentResult Index1()
        {
            return Content("This is the content to be returned");
        }
        public string Index2()
        {
            return "Hello";
        }
    }
}