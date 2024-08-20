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
    public class PaymentRepo: GenericRepositoryAsync<Payment> , IPaymentRepo
    {
        private readonly DbSet<Payment> payment;
        public PaymentRepo(AppDbContext appDbContext): base(appDbContext)
        {
                payment = appDbContext.Set<Payment>();
        }
    }
}
