using AutoMapper;
using FinApp.Core.Features.Accounts.Queries.Models;
using FinApp.Core.Features.Accounts.Queries.Responses;
using FinApp.Core.ResponseBase;
using FinApp.Data.Entites;
using FinApp.Service.Abstracts;
using FinApp.Service.Implementation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace FinApp
namespace FinApp.Core.Features.Accounts.Queries.Handlers
{
    public class AccountHandler : ResponseHandler ,IRequestHandler<GetAccountListQuery, Response<List<GetAccountListResponse>>>
    {
        private readonly IAccountService accountService;
        private readonly IMapper mapper;

        public AccountHandler(IAccountService accountService, IMapper mapper)
        {
            this.accountService = accountService;
            this.mapper = mapper;
        }
        public async Task<Response<List<GetAccountListResponse>>> Handle(GetAccountListQuery request, CancellationToken cancellationToken)
        {

            var accountsRespons = await accountService.GetAllAccountAsync();
            return Success(mapper.Map < List<GetAccountListResponse>> (accountsRespons));
        }
    }
}
