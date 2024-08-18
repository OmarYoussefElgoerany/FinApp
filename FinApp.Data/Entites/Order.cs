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
        [Required]
        public int UserId { get; set; } // Foreign Key to User

        [Required]
        public decimal TotalAmount { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; } // e.g., Pending, Completed, Cancelled

        // Navigation properties
        public virtual User User { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual Payment Payment { get; set; }
        public Order()
        {
            User = new User();
            OrderItems = new List<OrderItem>();
            Payment = new Payment();
        }
    }

}
