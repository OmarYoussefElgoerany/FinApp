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
    public class NotificationRepo: GenericRepositoryAsync<Notification>, INotificationRepo
    {
        private readonly DbSet<Notification> notifications;
        public NotificationRepo(AppDbContext appDbContext):base(appDbContext) 
        {
            notifications = appDbContext.Set<Notification>();
        }
    }
}
