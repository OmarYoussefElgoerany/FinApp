using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Data.Entites
{
    public class Budget : BaseEntity
    {
        //public Budget()
        //{
        //    User = new User();
        //}
        public int UserId { get; set; } // Foreign Key to User
        public string Category { get; set; } // e.g., Groceries, Bills
        public decimal Amount { get; set; } // Amount allocated for the budget category
        public DateTime StartDate { get; set; } // Start date of the budget
        public DateTime EndDate { get; set; } // End date of the budget

        // Navigation properties
        public virtual User User { get; set; }
    }

}
