using AutoMapper;
using FinApp.Core.Features.Accounts.Commands.Models;
using FinApp.Core.Features.Accounts.Commands.Response;
using FinApp.Core.ResponseBase;
using FinApp.Data.Entites;
using FinApp.Service.Abstracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Core.Features.Accounts.Commands.Handlers
{
    public class AccountCommandHandler :ResponseHandler, IRequestHandler<AddAccountCommand, Response<AddAccountResponse>>
    {
        private readonly IAccountService accountService;
        private readonly IMapper mapper;

        public AccountCommandHandler(IAccountService accountService, IMapper mapper, IUserService userServ)
        {
            
            this.accountService = accountService;
            this.mapper = mapper;
        }
        public async Task<Response<AddAccountResponse>> Handle(AddAccountCommand request, CancellationToken cancellationToken)
        {
            
            var mapToAccount = mapper.Map<Account>(request);
            var addAcc = await accountService.AddAsync(mapToAccount);
            var acccount = await accountService.GetAccountIncludeUseAsync(mapToAccount.Id);
            var toAccResp = mapper.Map<AddAccountResponse>(acccount);

            return Created(toAccResp);
        }
    }
}
