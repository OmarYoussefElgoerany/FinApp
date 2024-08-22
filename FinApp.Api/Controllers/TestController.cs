using FinApp.Core.Features.Accounts.Commands.Models;
using FinApp.Core.Features.Accounts.Commands.Response;
using FinApp.Core.Features.Accounts.Queries.Models;
using FinApp.Core.Features.Accounts.Queries.Responses;
using FinApp.Core.ResponseBase;
using FinApp.Data.Entites;
using FinApp.Infrastructure.Abstracts;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace FinApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController
    {
        private readonly IMediator mediator;

        public TestController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public async Task<Response<List<GetAccountListResponse>>> getAll()
        {
            var resp = await mediator.Send(new GetAccountListQuery());
            return resp;
        }
        [HttpPost]
        public async Task<Response<AddAccountResponse>> Add(AddAccountCommand addAccount)
        {
            return await mediator.Send(addAccount);
        }
    }
}
