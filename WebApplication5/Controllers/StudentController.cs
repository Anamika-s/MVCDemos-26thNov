using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;
namespace WebApplication5.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult GetDetails()
        {
            Student student = new Student()
            { Id = 1, Name = "Deepak", BatchCode = "B001", Marks = 90 };
            ViewBag.student = student;
            return View();
        }
        public ActionResult GetDetails2()
        {
            Student student = new Student()
            { Id = 1, Name = "Deepak", BatchCode = "B001", Marks = 90 };
            ViewData["student"] = student;
            return View();
        }

        public ActionResult List1()
        {
            List<Student> list = new List<Student>()
            {
                 new Student()  { Id = 1, Name = "Deepak", BatchCode = "B001", Marks = 90 },
                 new Student()  { Id = 2, Name = "Deepak", BatchCode = "B001", Marks = 90 },
                 new Student()  { Id = 3, Name = "Deepak", BatchCode = "B001", Marks = 90 },
                 new Student()  { Id = 4, Name = "Deepak", BatchCode = "B001", Marks = 90 }
            };
            ViewBag.students = list;
            return View();
        }

        public ActionResult List2()
        {
            List<Student> list = new List<Student>()
            {
                 new Student()  { Id = 1, Name = "Deepak", BatchCode = "B001", Marks = 90 },
                 new Student()  { Id = 2, Name = "Deepak", BatchCode = "B001", Marks = 90 },
                 new Student()  { Id = 3, Name = "Deepak", BatchCode = "B001", Marks = 90 },
                 new Student()  { Id = 4, Name = "Deepak", BatchCode = "B001", Marks = 90 }
            };
            ViewBag.students = list;
            return View();
        }
        public ActionResult List3()
        {
            List<Student> list = new List<Student>()
            {
                 new Student()  { Id = 1, Name = "Deepak", BatchCode = "B001", Marks = 90 },
                 new Student()  { Id = 2, Name = "Deepak", BatchCode = "B001", Marks = 90 },
                 new Student()  { Id = 3, Name = "Deepak", BatchCode = "B001", Marks = 90 },
                 new Student()  { Id = 4, Name = "Deepak", BatchCode = "B001", Marks = 90 }
            };
            ViewData["students"] = list;
            return View();
        }
    }
}