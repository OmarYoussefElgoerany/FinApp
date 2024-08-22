using FinApp.Data.Entites;
using FinApp.Infrastructure.Abstracts;
using FinApp.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepo userRepo;

        public UserService(Infrastructure.Abstracts.IUserRepo userRepo)
        {
            this.userRepo = userRepo;
        }
        public async Task<User> GetUserById(int id)
        {
            return await userRepo.GetByIdAsync(id);
        }
    }
}
