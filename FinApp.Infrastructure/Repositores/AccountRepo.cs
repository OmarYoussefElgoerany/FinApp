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
        public AccountRepo(AppDbContext appDbContext):base(appDbContext)
        {
            accountRepo = appDbContext.Set<AccountRepo>();
        }
    }
}
