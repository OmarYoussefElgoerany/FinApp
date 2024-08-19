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
        public int UserId { get; set; } // Foreign Key to User
        public string AccountNumber { get; set; } // Unique
        public string AccountType { get; set; } // e.g., Checking, Savings
        public decimal Balance { get; set; }
        public string Currency { get; set; } = "USD";

        // Navigation properties
        public virtual User User { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Transfer> TransfersSent { get; set; }
        public virtual ICollection<Transfer> TransfersReceived { get; set; }
        //public Account()
        //{
        //    Transactions = new List<Transaction>();
        //    TransfersReceived = new List<Transfer>();
        //    TransfersSent = new List<Transfer>();
        //}
    }
}
