
using FinApp.Core;
using FinApp.Infrastructure;
using FinApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Service;

namespace FinApp.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            #region Database

            var connectionString = builder.Configuration.GetConnectionString("FinApp");
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString));

            #endregion
            #region Dependency Injection
            builder.Services
                .AddInfrastructureDependencies()
                .AddServiceDependencies()
                .AddCoreDependencies();
            #endregion
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
