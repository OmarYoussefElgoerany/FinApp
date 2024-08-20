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
    public class AuditLogRepo: GenericRepositoryAsync<AuditLog>, IAuditLogRepo
    {
        private readonly DbSet<AuditLog> auditLog;
        public AuditLogRepo(AppDbContext appDbContext):base(appDbContext) 
        {
            auditLog = appDbContext.Set<AuditLog>();
        }
    }
}
