using Microsoft.AspNetCore.Mvc;
using FibonacciApi.Entities;

namespace FibonacciApi.Controllers
{
    [ApiController]
    [Route("")]
    public class FibonacciController : ControllerBase
    {
        [HttpGet("{number}")]
        public ActionResult<FibonacciNumber> CheckNumber(int number)
        {
            FibonacciNumber num = new FibonacciNumber();
            num.Number = number;

            return Ok(num);
        }
    }
}
