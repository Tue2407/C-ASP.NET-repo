using StudentAdministrationSystem.Models;
using StudentAdministrationSystem.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentAdministrationSystem.Controllers
{
    public class SubjectController : Controller
    {
        // GET: Subject
        public ActionResult Index()
        {
            return View(SubjectStorage.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Subject subject)
        {
            SubjectStorage.Add(subject);
            return RedirectToAction("Index");
        }


    }
}