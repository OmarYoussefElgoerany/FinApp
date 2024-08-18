using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinApp.Data.Entites
{
    public class Payment : BaseEntity
    {
        [Required]
        public int UserId { get; set; } // Foreign Key to User

        [Required]
        public decimal Amount { get; set; }

        [Required]
        [StringLength(50)]
        public string PaymentMethod { get; set; } // e.g., Credit Card, PayPal, Stripe

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; } // e.g., Pending, Completed, Failed

        [Required]
        public int OrderId { get; set; } // Foreign Key to Order

        // Navigation properties
        public virtual User User { get; set; }
        public virtual Order Order { get; set; }
        public Payment()
        {
            User = new User();
            Order = new Order();
        }
    }


}
