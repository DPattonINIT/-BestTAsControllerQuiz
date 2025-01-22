
using _BestTAsControllerQuiz.Services;
using Microsoft.AspNetCore.Mvc;

namespace _BestTAsControllerQuiz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbersController : ControllerBase
    {
        private readonly AddTwoNumbersService _addTwoNumbersService;
        public AddTwoNumbersController(AddTwoNumbersService addTwoNumbersService)
        {
            _addTwoNumbersService = addTwoNumbersService;
        }
        [HttpGet]
        [Route("AddTwoNumbers/{userNum1}/{userNum2}")]

        public string AddingNumbers(int userNum1, int userNum2)
        {
            int results = userNum1 + userNum2;
            return $"{userNum1} + {userNum2} = {results}  ";
        }
    }
}