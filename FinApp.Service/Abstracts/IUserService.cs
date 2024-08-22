using FinApp.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Service.Abstracts
{
    public interface IUserService
    {
        Task<User> GetUserById(int id);
    }
}
