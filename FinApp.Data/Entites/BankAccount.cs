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
        [Required]
        public int UserId { get; set; } // Foreign Key to User

        [Required]
        [StringLength(100)]
        public string AccountHolderName { get; set; }

        [Required]
        [StringLength(100)]
        public string BankName { get; set; }

        [Required]
        [StringLength(20)]
        public string AccountNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string RoutingNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountType { get; set; } // e.g., Checking, Savings

        // Navigation properties
        public virtual User User { get; set; }
        public virtual ICollection<Transfer> Transfers { get; set; }
        public BankAccount()
        {
            User = new User();
            Transfers = new HashSet<Transfer>();
        }
    }

}
