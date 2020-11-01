using System;
using System.ComponentModel.DataAnnotations;

namespace Pumox.Models
{
    public enum JobTitles
    {
        Administrator,
        Developer,
        Architect,
        Manager
    };

    public class Employee : IDisposable
    {
        public long Id { get; set; }
        public long CompanyId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string JobTitle { get; set; }

        public void Dispose() {}
    }
}