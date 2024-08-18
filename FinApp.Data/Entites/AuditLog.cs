using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Data.Entites
{
    public class AuditLog : BaseEntity
    {
        [Required]
        public int UserId { get; set; } // Foreign Key to User

        [Required]
        [StringLength(50)]
        public string Action { get; set; } // e.g., Login, Transfer, Payment

        [Required]
        public DateTime Timestamp { get; set; } // Timestamp of the action

        [StringLength(500)]
        public string Details { get; set; } // Additional details about the action

        // Navigation properties
        public virtual User User { get; set; }
        public AuditLog()
        {
            User = new User();
        }
    }
}
