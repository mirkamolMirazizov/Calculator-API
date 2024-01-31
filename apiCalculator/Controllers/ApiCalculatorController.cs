using Microsoft.AspNetCore.Mvc;

namespace apiCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiCalculatorController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World!");
        }

        [HttpGet("Add")]
        public IActionResult Add(decimal num1, decimal num2)
        {
            return Ok(num1 + num2);
        }

        [HttpGet("Subtract")]
        public IActionResult Subtract(decimal num1, decimal num2)
        {
            return Ok(num1 - num2);
        }

        [HttpGet("Multiply")]
        public IActionResult Multiply(decimal num1, decimal num2)
        {
            return Ok(num1 * num2);
        }

        [HttpGet("Divide")]
        public ActionResult Divide(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                return BadRequest("Can't divide by zero");
            }
            else
            {
                return Ok(num1 / num2);
            }
        }

        [HttpGet("Modulo")]
        public ActionResult Modulo(decimal num1, decimal num2)
        {
            if (num1 == 0)
            {
                return BadRequest("Can't calculate modulo with zero divisor");
            }

            decimal result = num1 % num2;
            return Ok(result);
        }
    }

}
