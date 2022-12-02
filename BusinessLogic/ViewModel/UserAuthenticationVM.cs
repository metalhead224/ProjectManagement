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
    public class UserAuthenticationVM
    {
        public int Id { get; set; }

        [ForeignKey("Users")]
        public int UserId { get; set; }
        public virtual Users Users { get; set; }

        [Required]
        public string Hash { get; set; }

        [Required]
        public string Salt { get; set; }
        public int LoginAttempt { get; set; }
        public bool IsBlocked { get; set; }
    }
}
