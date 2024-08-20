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
    public class BankAccountRepo: GenericRepositoryAsync<BankAccount>, IBankAccount
    {
        private readonly DbSet<BankAccount> bankAccount;
        public BankAccountRepo(AppDbContext appDbContext):base(appDbContext) 
        {
            bankAccount = appDbContext.Set<BankAccount>();
        }
    }
}
