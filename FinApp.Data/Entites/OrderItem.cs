using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinApp.Data.Entites
{
    public class OrderItem : BaseEntity
    {
        [Required]
        public int OrderId { get; set; } // Foreign Key to Order

        [Required]
        [StringLength(255)]
        public string ProductName { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        // Navigation properties
        public virtual Order Order { get; set; }
        public OrderItem()
        {
            Order = new Order();
        }
    }
}
