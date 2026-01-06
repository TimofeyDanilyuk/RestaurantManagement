using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagement.Infrastructure.Repositories;

namespace RestaurantManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        private readonly IDishRepository _dishRepository;

        public DishesController(IDishRepository dishRepository)
        {
            _dishRepository = dishRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var dishes = await _dishRepository.GetAllAsync();
            return Ok(dishes);
        }
    }
}
