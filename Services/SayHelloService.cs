using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _BestTAsControllerQuiz.Services
{
    public class SayHelloService
    {
        public string AddName(string name)
        {
            string Name = name;
                return $"Hello {Name}";
            
            

        } 
    }
}