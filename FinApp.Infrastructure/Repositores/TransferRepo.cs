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
    public class TransferRepo: GenericRepositoryAsync<Transfer>, ITransferRepo
    {
        private readonly DbSet<Transfer> transferRepo;
        public TransferRepo(AppDbContext appDbContext) : base(appDbContext)
        {
            transferRepo = appDbContext.Set<Transfer>();
        }
    }
}
