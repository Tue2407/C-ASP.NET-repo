using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentAdministrationSystem.Storage;

namespace StudentAdministrationSystem.Models
{
    public class SubjectAndStudentsViewModel
    {
        public SubjectAndStudentsViewModel(Student student)
        {
            Student = student;
            Subjects = SubjectStorage.GetAll();
        }

        public List<Subject> Subjects{ get; set; }

        public Student Student { get; set; }

        public Subject Subject { get; set; }
    }
}