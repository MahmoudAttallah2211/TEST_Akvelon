using Microsoft.AspNetCore.Mvc;
using TEST_Akvelon.Models;
using TEST_Akvelon.Repositories;

namespace TEST_Akvelon.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        [HttpPost("process")]
        public IActionResult ProcessFizzBuzz([FromBody] FizzBuzzRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Input))
            {
                return BadRequest("Input string cannot be null or empty.");
            }

            var result = _fizzBuzzService.GetOverlappings(request.Input);
            return Ok(result);
        }
    }
}
