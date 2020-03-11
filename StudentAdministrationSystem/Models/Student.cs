using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace StudentAdministrationSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [DisplayName("Navn")]
        public string Name { get; set; }
        [DisplayName("e-mail adress")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public List<Subject> Subjects { get; set; }

        public Subject AddSubject(Subject subject)
        {
            Subjects.Add(subject);
            return subject;
        }
    }
}