using AutoMapper;

namespace FinApp.Core.Mapping.AccountMapper
{
    public partial class AccountProfile : Profile
    {
        public AccountProfile()
        {
            GetAccountListMapping();
            GetAccountMapping();
            AddAccountMapping();
        }
    }
}

