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
    public class BudgetRepo: GenericRepositoryAsync<Budget> , IBudgetRepo
    {
        private readonly DbSet<Budget> budget;
        public BudgetRepo(AppDbContext appDbContext):base(appDbContext)
        {
            budget = appDbContext.Set<Budget>();
        }
    }
}
