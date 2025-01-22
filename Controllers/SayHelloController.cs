using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _BestTAsControllerQuiz.Services;
using Microsoft.AspNetCore.Mvc;

namespace _BestTAsControllerQuiz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
         private readonly SayHelloService _sayHelloService;

        public SayHelloController(SayHelloService sayHelloService)
        {
            _sayHelloService = sayHelloService;
        }

        [HttpPost]
        [Route("SayHello/{name}")]

        public string AddName(string name)
        {
            return _sayHelloService.AddName(name);
        }
    }
}