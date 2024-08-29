using FinApp.Api.Base;
using FinApp.Core.Features.Accounts.Commands.Models;
using FinApp.Core.Features.Accounts.Queries.Models;
using FinApp.Data.AppRouter;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FinApp.Api.Controllers
{
    [ApiController]
    public class TestController : BaseController
    {
        public TestController(IMediator mediator) : base(mediator)
        {

        }

        [HttpGet(Router.AccountRouting.List)]
        public async Task<IActionResult> getAll()
        {
            var resp = await mediator.Send(new GetAccountListQuery());
            return Ok(resp);
        }
        [HttpPost(Router.AccountRouting.Create)]
        public async Task<IActionResult> Add(AddAccountCommand addAccount)
        {
            return NewResult(await mediator.Send(addAccount));
        }
        [HttpGet(Router.AccountRouting.GetByID)]
        public async Task<IActionResult> GetById(int id)
        {
            return NewResult(await mediator.Send(new GetAccountQuery(id)));
        }

    }
}
