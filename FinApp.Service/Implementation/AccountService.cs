using FinApp.Data.Entites;
using FinApp.Infrastructure.Abstracts;
using FinApp.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Service.Implementation
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepo accountRepo;

        public AccountService(IAccountRepo accountRepo)
        {
            this.accountRepo = accountRepo;
        }

        public async Task<Account> AddAsync(Account account)
        {
            await accountRepo.AddAsync(account);
            await accountRepo.SaveChangesAsync();
            return account;
        }

        public async Task<List<Account>> GetAllAccountAsync()
        {
            return await accountRepo.GetAllAsync();
        }

        public Task<Account> GetByFullName(string fullName)
        {
            accountRepo.get
        }
    }
}
