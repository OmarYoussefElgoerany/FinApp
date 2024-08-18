using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Data.Entites
{
    public class Notification : BaseEntity
    {
        [Required]
        public int UserId { get; set; } // Foreign Key to User

        [Required]
        [StringLength(500)]
        public string Message { get; set; } // Notification message

        [Required]
        [StringLength(50)]
        public string Type { get; set; } // e.g., Transaction Alert, Payment Reminder

        [Required]
        public bool IsRead { get; set; } // Indicates if the notification has been read

        // Navigation properties
        public virtual User User { get; set; }
        public Notification()
        {
            User = new User();
        }
    }

}
