using FinApp.Core.Features.Accounts.Queries.Responses;
using FinApp.Data.Entites;
using MediatR;
using FinApp.Core.ResponseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Core.Features.Accounts.Queries.Models
//namespace FinApp
{
    //This is my req and                      this is my response !!
    public class GetAccountListQuery : IRequest<Response<List<GetAccountListResponse>>>
    {
    }
}
