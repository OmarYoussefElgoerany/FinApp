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
    public class OrderItemRepo: GenericRepositoryAsync<OrderItem>, IOrderItemRepo
    {
        private readonly DbSet<OrderItem> orderItem;
        public OrderItemRepo(AppDbContext appDbContext):base(appDbContext)
        {
            orderItem = appDbContext.Set<OrderItem>(); 
        }
    }
}
