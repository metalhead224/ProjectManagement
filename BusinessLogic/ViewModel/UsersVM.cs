using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModel
{
    public class UsersVM
    {
        public int Id { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        [ForeignKey("Roles")]
        public int RoleId { get; set; }
        public virtual Roles Roles { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PersonalEmail { get; set; }

        public string? OfficeEmail { get; set; }

        [Required]
        public string ContactNumber1 { get; set; }
        public string? ContactNumber2 { get; set; }

        public string? PhoneExtension { get; set; }
        public bool IsActive { get; set; }

        [Required]
        public string CurrentPosition { get; set; }

        public bool IsTeamLead { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
