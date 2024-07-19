using laptop_service.Models;
using laptop_service.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace laptop_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaptopController : ControllerBase
    {
        private readonly ILaptopRepository laptopRepository;

        public LaptopController(ILaptopRepository _laptopRepository)
        {
            laptopRepository = _laptopRepository;
        }

        [HttpGet("/api/laptops")]
        public IActionResult GetAll()
        {
            var laptops = laptopRepository.DisplayAllLaptops();
            if (laptops == null)
                return NotFound();
            return Ok(laptops);
        }

        [HttpGet("/api/laptops/{id}")]
        public IActionResult GetOne(int id)
        {
            var laptop = laptopRepository.DisplayLaptopById(id);
            if (laptop == null)
                return NotFound();
            return Ok(laptop);
        }
    }
}
