using FinApp.Data.Entites;
using FinApp.Infrastructure.InfrastructureBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Infrastructure.Abstracts
{
    internal interface IBudgetRepo : IGenericRepoAsync<Budget>
    {
    }
}
