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
        private readonly IUserService userService;

        public AccountService(IAccountRepo accountRepo, IUserService userService)
        {
            this.accountRepo = accountRepo;
            this.userService = userService;
        }

        public async Task<Account> AddAsync(Account account)
        {
            await accountRepo.AddAsync(account);
            await accountRepo.SaveChangesAsync();
            return account;
        }

        public async Task<Account> GetAccountIncludeUseAsync(int id)
        {
            return await accountRepo.GetAccountIncludeUserAsync(id);
        }


        public async Task<List<Account>> GetAllAccountAsync()
        {
            return await accountRepo.GetAllAsync();
        }

      
    }
}
