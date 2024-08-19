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
        //public OrderItem()
        //{
        //    Order = new Order();
        //}
        public int OrderId { get; set; } // Foreign Key to Order
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }

        // Navigation properties
        public virtual Order Order { get; set; }
    }
}
