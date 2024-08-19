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
        //public Notification()
        //{
        //    User = new User();
        //}
        public int UserId { get; set; } // Foreign Key to User
        public string Message { get; set; } // Notification message
        public string Type { get; set; } // e.g., Transaction Alert, Payment Reminder
        public bool IsRead { get; set; } // Indicates if the notification has been read

        // Navigation properties
        public virtual User User { get; set; }
    }

}
