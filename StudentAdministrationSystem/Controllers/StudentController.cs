using StudentAdministrationSystem.Models;
using StudentAdministrationSystem.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentAdministrationSystem.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View(StudentStorage.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            StudentStorage.Add(student);
            return RedirectToAction("Index");
        }
        
        public ActionResult Details(int id)
        {
            Student student = StudentStorage.Get(id);
            student.Subjects = new List<Subject> {new Subject { Name = "Temp Fag", Description = "det gode fag"}};
            return View(student);
        }

        public ActionResult AddLecture(int id)
        {
            return View(new SubjectAndStudentsViewModel(StudentStorage.Get(id)));
        }


    }
}