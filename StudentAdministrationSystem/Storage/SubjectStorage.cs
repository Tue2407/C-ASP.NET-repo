using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentAdministrationSystem.Models;

namespace StudentAdministrationSystem.Storage
{
    public class SubjectStorage
    {
        private static List<Subject> _subjects = new List<Subject>();

        public static void Add(Subject subject)
        {
            subject.SubjectId = _subjects.Count + 1;
            _subjects.Add(subject);
        }

        public static Subject Get(int id)
        {
            return (from s in _subjects where s.SubjectId == id select s).First();
        }

        public static List<Subject> GetAll()
        {
            return _subjects;
        }
    }
}