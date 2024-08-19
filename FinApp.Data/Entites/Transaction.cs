using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinApp.Data.Entites
{
    public class Transaction:BaseEntity
    {
        public int AccountID { get; set; }
        public decimal Amount { get; set; }
        public string TransactionType { get; set; } // e.g., Credit, Debit
        public string Category { get; set; } // e.g., Groceries, Bills, Entertainment
        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }

        // Navigation property
        public Account Account { get; set; }
    }

}
