using AutoMapper;
using FinApp.Core.Features.Accounts.Queries.Responses;
using FinApp.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Core.Mapping.AccountMapper
{
    public partial class AccountProfile : Profile
    {
        public void GetAccountMapping()
        {
            CreateMap<Account, GetAccountResponse>()
               .ForMember(des => des.UserName, opt => opt.MapFrom(src => src.User.FullName));
        }
    }
}
