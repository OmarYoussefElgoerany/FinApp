using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinApp.Data.Entites
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        [Required]
        [ForeignKey("Account")]
        public int AccountID { get; set; }
        public Account Account { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [Required]
        [MaxLength(20)]
        public string TransactionType { get; set; } // e.g., Credit, Debit

        [MaxLength(50)]
        public string Category { get; set; } // e.g., Groceries, Bills, Entertainment

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation property
        //public Account Account { get; set; }
    }

}
