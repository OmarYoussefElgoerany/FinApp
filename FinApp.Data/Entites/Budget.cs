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
        [Required]
        public int UserId { get; set; } // Foreign Key to User

        [Required]
        [StringLength(50)]
        public string Category { get; set; } // e.g., Groceries, Bills

        [Required]
        public decimal Amount { get; set; } // Amount allocated for the budget category

        [Required]
        public DateTime StartDate { get; set; } // Start date of the budget

        [Required]
        public DateTime EndDate { get; set; } // End date of the budget

        // Navigation properties
        public virtual User User { get; set; }
        public Budget()
        {
            User = new User();
        }
    }

}
