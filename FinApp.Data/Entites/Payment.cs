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
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } // e.g., Credit Card, PayPal, Stripe
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; } // e.g., Pending, Completed, Failed
        //public int OrderId { get; set; } // Foreign Key to Order
        public int UserId { get; set; } // Foreign Key to User

        // Navigation properties
        public virtual User User { get; set; }
        public virtual Order Order { get; set; }
        //public Payment()
        //{
        //    User = new User();
        //    Order = new Order();
        //}
    }


}
