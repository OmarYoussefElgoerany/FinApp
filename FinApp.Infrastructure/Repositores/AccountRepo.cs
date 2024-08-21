using FinApp.Data.Entites;
using FinApp.Infrastructure.Abstracts;
using FinApp.Infrastructure.Context;
using FinApp.Infrastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Infrastructure.Repositores
{
    public class AccountRepo:GenericRepositoryAsync<Account>, IAccountRepo
    {
        private readonly DbSet<AccountRepo> accountRepo;
        private readonly AppDbContext appDbContext;

        public AccountRepo(AppDbContext appDbContext):base(appDbContext)
        {
            accountRepo = appDbContext.Set<AccountRepo>();
            this.appDbContext = appDbContext;
        }

        public async Task<Account> GetByFullName(string fullName)
        {
            return await appDbContext.Set<Account>().Include(a => a.User).FirstOrDefaultAsync(a => a.User.FullName == fullName);
        }
    }
}
