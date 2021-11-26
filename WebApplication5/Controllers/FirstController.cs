﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult  Action1()
        {
            return View();
        }

        public ActionResult Action2()
        {
            ViewData["name"] = "deepak";
            ViewData["Date"] = DateTime.Today.ToShortDateString();
            return View();
        }
        public ActionResult Action3()
        {
           ViewBag.name = "deepak";
           ViewBag.date= DateTime.Today.ToShortDateString();
           return View();
        }
    }
}