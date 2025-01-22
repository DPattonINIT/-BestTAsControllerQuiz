using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _BestTAsControllerQuiz.Services
{
    public class ReverseItService
    {
         public string ReverseNumber(string number)
        {

            string reversedNumber = new string(number.ToCharArray().Reverse().ToArray());


            return $"You entered {number}, reversed is {reversedNumber}";
        }  
    }
}