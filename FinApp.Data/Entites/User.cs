using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FinApp.Data.Entites
{
    public class User : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(255)]
        public string Email { get; set; } // Unique

        [Required]
        public string PasswordHash { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string ProfilePictureURL { get; set; }

        public DateTime? LastLoginAt { get; set; }

        public bool IsVerified { get; set; }

        // Navigation properties
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<BankAccount> BankAccounts { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual ICollection<AuditLog> AuditLogs { get; set; }
        //public User()
        //{
        //    Accounts = new HashSet<Account>();
        //    Notifications = new HashSet<Notification>();
        //    BankAccounts = new HashSet<BankAccount>();
        //    Payments = new HashSet<Payment>();
        //    Orders = new HashSet<Order>();
        //    Budgets = new HashSet<Budget>();
        //    AuditLogs = new HashSet<AuditLog>();

        //}
    }
}
