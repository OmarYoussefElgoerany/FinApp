using FinApp.Core.Features.Accounts.Commands.Models;
using FinApp.Core.Features.Accounts.Commands.Response;
using FinApp.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Core.Mapping.AccountMapper
{
    public partial class AccountProfile
    {
        public void AddAccountMapping()
        {
            CreateMap<AddAccountCommand, Account>()
                .ForMember(des => des.UserId, opt => opt.MapFrom(src => src.UserId));
            CreateMap<Account, AddAccountResponse>()
                .ForMember(des => des.UserName, opt => opt.MapFrom(src => src.User.FullName));

        }
    }
}
