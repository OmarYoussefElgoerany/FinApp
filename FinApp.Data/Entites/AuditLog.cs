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
        //public AuditLog()
        //{
        //    User = new User();
        //}
        public int UserId { get; set; } // Foreign Key to User
        public string Action { get; set; } // e.g., Login, Transfer, Payment
        public DateTime Timestamp { get; set; } // Timestamp of the action
        public string Details { get; set; } // Additional details about the action

        // Navigation properties
        public virtual User User { get; set; }
      
    }
}
