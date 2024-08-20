using FinApp.Data.Entites;
using FinApp.Infrastructure.InfrastructureBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Infrastructure.Abstracts
{
    public interface ITransferRepo : IGenericRepoAsync<Transfer>
    {
    }
}
