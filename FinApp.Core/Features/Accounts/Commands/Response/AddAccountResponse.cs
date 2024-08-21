using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Core.Features.Accounts.Commands.Response
{
    public class AddAccountResponse 
    {
        public string UserName { get; set; } // Foreign Key to User
        public string AccountNumber { get; set; } // Unique
        public string AccountType { get; set; } // e.g., Checking, Savings
    }
}
