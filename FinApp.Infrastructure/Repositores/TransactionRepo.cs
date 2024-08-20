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
    public class TransactionRepo: GenericRepositoryAsync<Transaction>,ITransactionRepo
    {
        private readonly DbSet<Transaction> _transactions;
        public TransactionRepo(AppDbContext appDbContext):base(appDbContext)
        {
            _transactions = appDbContext.Set<Transaction>();
        }
    }
}
