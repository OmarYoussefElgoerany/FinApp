using FinApp.Core.Features.Accounts.Queries.Responses;
using FinApp.Core.ResponseBase;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Core.Features.Accounts.Queries.Models
{
    public class GetAccountQuery :IRequest<Response<GetAccountResponse>>
    {
        public int Id { get; set; }
        public GetAccountQuery()
        {
            
        }
        public GetAccountQuery(int id)
        {
            this.Id = id;
        }
    }
}
