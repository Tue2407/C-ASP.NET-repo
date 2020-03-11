﻿namespace StudentAdministrationSystem.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        override
        public string ToString()
        {
            return Name;
        }
    }
}