using FinApp.Infrastructure.Abstracts;
using FinApp.Infrastructure.InfrastructureBases;
using FinApp.Infrastructure.Repositores;
using Microsoft.Extensions.DependencyInjection;

namespace FinApp.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection service)
        {
            service.AddTransient<IAccountRepo, AccountRepo>();
            service.AddTransient<IBankAccount, BankAccountRepo>();
            service.AddTransient<INotificationRepo, NotificationRepo>();
            service.AddTransient<ITransferRepo, TransferRepo>();
            service.AddTransient<ITransactionRepo, TransactionRepo>();
            service.AddTransient<IOrderRepo, OrderRepo>();
            service.AddTransient<IOrderItemRepo, OrderItemRepo>();
            service.AddTransient<IPaymentRepo, PaymentRepo>();
            service.AddTransient<IAuditLogRepo, AuditLogRepo>();
            service.AddTransient<IBudgetRepo, BudgetRepo> ();
            service.AddTransient<IUserRepo, UserRepo>();
            service.AddTransient(typeof(IGenericRepoAsync<>), typeof(GenericRepositoryAsync<>));

            return service;
        }
    }
}
