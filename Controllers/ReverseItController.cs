
using System.Threading.Tasks;
using _BestTAsControllerQuiz.Services;
using Microsoft.AspNetCore.Mvc;

namespace _BestTAsControllerQuiz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItController : ControllerBase
    {
        private readonly ReverseItService _reverseItService;
        public ReverseItController(ReverseItService reverseItService)
        {
            _reverseItService = reverseItService;
        }

        [HttpGet("{number}")]
        public string ReverseNumber(string number)
        {

            if (!int.TryParse(number, out int parsedNumber))
            {

                return "Invalid input. Please enter a valid number.";
            }
            return _reverseItService.ReverseNumber(number);
        }
    }
}
