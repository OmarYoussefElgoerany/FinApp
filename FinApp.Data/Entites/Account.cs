using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Transactions;


namespace FinApp.Data.Entites
{
    public class Account : BaseEntity
    {
        [Required]
        public int UserId { get; set; } // Foreign Key to User

        [Required]
        [StringLength(20)]
        public string AccountNumber { get; set; } // Unique

        [Required]
        [StringLength(50)]
        public string AccountType { get; set; } // e.g., Checking, Savings

        [Required]
        public decimal Balance { get; set; }

        [Required]
        [StringLength(10)]
        public string Currency { get; set; } = "USD";

        // Navigation properties
        public virtual User User { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Transfer> TransfersSent { get; set; }
        public virtual ICollection<Transfer> TransfersReceived { get; set; }
        public Account()
        {
            Transactions = new List<Transaction>();
            TransfersReceived = new List<Transfer>();
            TransfersSent = new List<Transfer>();
        }
    }
}
