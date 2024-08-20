using FinApp.Data.Entites;
using FinApp.Infrastructure.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FinApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController
    {
        private readonly IUserRepo userRepo;

        public TestController(IUserRepo userRepo)
        {
            this.userRepo = userRepo;
        }
        [HttpGet]
        public async Task<List<User>>getAll()
        {
            return await userRepo.GetAllAsync();
        }
    }
}
