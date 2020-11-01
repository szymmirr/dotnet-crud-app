using System;

namespace Pumox.Models
{
    public class Search
    {
        public long Id { get; set; }
        public string Keyword { get; set; }
        public DateTime EmployeeDateOfBirthFrom { get; set; }
        public DateTime EmployeeDateOfBirthTo { get; set; }
        public string JobTitle { get; set; }

        // Navigation property
        public Company Company { get; set; }
        // Navigation property
        public Employee Employee { get; set; }
    }
}