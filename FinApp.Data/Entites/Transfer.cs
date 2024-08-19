using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinApp.Data.Entites
{
    public class Transfer : BaseEntity
    {
        public int SenderAccountId { get; set; } // Foreign Key to Account
        public int? ReceiverAccountId { get; set; } // Foreign Key to Account or BankAccount
        public decimal Amount { get; set; }
        public DateTime TransferDate { get; set; }
        public string Status { get; set; } // e.g., Pending, Completed, Failed

        // Navigation properties
        public virtual Account SenderAccount { get; set; }
        public virtual Account ReceiverAccount { get; set; }
        public virtual BankAccount BankAccountReceiver { get; set; }
        //public Transfer()
        //{
        //    SenderAccount = new Account();
        //    ReceiverAccount = new Account();
        //    BankAccountReceiver = new BankAccount();
        //}
    }

}
