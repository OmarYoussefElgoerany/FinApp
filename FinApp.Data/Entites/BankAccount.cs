using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Data.Entites
{
    public class BankAccount : BaseEntity
    {
        public int UserId { get; set; } // Foreign Key to User
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string RoutingNumber { get; set; }
        public string AccountType { get; set; } // e.g., Checking, Savings

        // Navigation properties
        public virtual User User { get; set; }
        public virtual ICollection<Transfer> Transfers { get; set; }
        //public BankAccount()
        //{
        //    User = new User();
        //    Transfers = new HashSet<Transfer>();
        //}
    }

}
