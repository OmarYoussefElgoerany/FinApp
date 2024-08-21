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

        public AccountCommandHandler(IAccountService accountService, IMapper mapper)
        {
            this.accountService = accountService;
            this.mapper = mapper;
        }
        public async Task<Response<AddAccountResponse>> Handle(AddAccountCommand request, CancellationToken cancellationToken)
        {
            
            var accountMap = mapper.Map<Account>(request);
            var addAcc = await accountService.AddAsync(accountMap);
            var toAccResp = mapper.Map<AddAccountResponse>(addAcc);

            return Created(toAccResp);
        }
    }
}
