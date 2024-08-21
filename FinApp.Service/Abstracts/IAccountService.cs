using FinApp.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Service.Abstracts
{
    public interface IAccountService
    {
        Task<List<Account>> GetAllAccountAsync(); 
        Task<Account> AddAsync(Account account);
        Task<Account> GetByFullName(string fullName);
    }
}
