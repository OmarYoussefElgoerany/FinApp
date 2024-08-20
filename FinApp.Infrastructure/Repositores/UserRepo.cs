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
    public class UserRepo : GenericRepositoryAsync<User>, IUserRepo
    {
        private readonly DbSet<User> userRepo;
        public UserRepo(AppDbContext appDbContext):base(appDbContext) 
        {
            userRepo = appDbContext.Set<User>();
        }
    }
}
