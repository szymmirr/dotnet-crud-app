using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pumox.Models
{
    public class Company
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int EstablishmentYear { get; set; }
        public IList<Employee> Employees { get; set; }
    }
}