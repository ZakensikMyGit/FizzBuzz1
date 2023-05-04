using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string GetFizzBuzz(int number)
        {
            string text;
            if (number % 15 == 0)
            {
                text = "FizzBuzz";
            }
            else if (number % 5 == 0)
            {
                text = "Buzz";
            }
            else if (number % 3 == 0)
            {
                text = "Fizz";
            }
            else
            {
                text = $"Twoja liczba to {number}, GAME OVER";
            }

            return text;
        }
    }
}
