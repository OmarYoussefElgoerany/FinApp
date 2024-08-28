using FinApp.Core.Features.Accounts.Commands.Models;
using FinApp.Core.Features.Accounts.Commands.Response;
using FinApp.Core.Features.Accounts.Queries.Models;
using FinApp.Core.Features.Accounts.Queries.Responses;
using FinApp.Core.ResponseBase;
using FinApp.Data.AppRouter;
using FinApp.Data.Entites;
using FinApp.Infrastructure.Abstracts;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace FinApp.Api.Controllers
{
    [ApiController]
    public class TestController
    {
        private readonly IMediator mediator;

        public TestController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet(Router.AccountRouting.List)]
        public async Task<Response<List<GetAccountListResponse>>> getAll()
        {
            var resp = await mediator.Send(new GetAccountListQuery());
            return resp;
        }
        [HttpPost(Router.AccountRouting.Create)]
        public async Task<Response<AddAccountResponse>> Add(AddAccountCommand addAccount)
        {
            return await mediator.Send(addAccount);
        }
        [HttpGet(Router.AccountRouting.GetByID)]
        public async Task<Response<GetAccountResponse>> GetById(int id)
        {
            return await mediator.Send(new GetAccountQuery(id));
        }

    }
}
