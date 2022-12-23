using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string ContactNumber1 { get; set; }
        public string? ContactNumber2 { get; set; }

        [Required]
        public string PersonalEmail { get; set; }

        public string? OfficeEmail { get; set; }

        
        public int CreatedBy { get; set; }

        
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}
