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
    public class OrderRepo : GenericRepositoryAsync<Order>, IOrderRepo
    {
        private readonly DbSet<Order> orders;
        public OrderRepo(AppDbContext appDbContext):base(appDbContext)
        {
            orders = appDbContext.Set<Order>();
        }
    }
}
