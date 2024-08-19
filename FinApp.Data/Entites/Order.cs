using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinApp.Data.Entites
{
    public class Order : BaseEntity
    {
        //public Order()
        //{
        //    User = new User();
        //    OrderItems = new List<OrderItem>();
        //    Payment = new Payment();
        //}
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } // e.g., Pending, Completed, Cancelled
        public int UserId { get; set; } // Foreign Key to User
        public int PaymentID { get; set; } // Foreign Key to Order

        // Navigation properties
        public virtual User User { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual Payment Payment { get; set; }
        
    }

}
