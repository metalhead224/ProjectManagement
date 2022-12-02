using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModel
{
    public class BranchVM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }
        public bool IsHeadOffice { get; set; }
        public bool IsRegionalHead { get; set; }

        [Required]
        public string ContactNumber1 { get; set; }

        [Required]
        public string? ContactNumber2 { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string ShortName { get; set; }
        public int ContactPerson { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
