using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Core.Features.Accounts.Queries.Responses
{
    public class GetAccountListResponse
    {
        public int UserId { get; set; } // Foreign Key to User
        public string AccountNumber { get; set; } // Unique
        public string AccountType { get; set; } // e.g., Checking, Savings
        public decimal Balance { get; set; }
        public string Currency { get; set; } = "USD";
    }
}
