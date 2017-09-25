using StudentAdministrationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentAdministrationSystem.Storage
{
    public static class StudentStorage
    {
        private static List<Student> _students = new List<Student>();

        public static void Add(Student student)
        {
            student.StudentId = _students.Count + 1;
            _students.Add(student);
        }

        public static Student Get(int id)
        {
            return (from s in _students where s.StudentId == id select s).First();
        }

        public static List<Student> GetAll()
        {
            return _students;
        }
    }
}