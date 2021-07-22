using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number2 = 0;

            while (true)
            {
                Console.WriteLine("Enter number for addition | type \"ok\" to exit");
                var userInput = Console.ReadLine();
               
                if (userInput != "ok")
                {
                    int number = Convert.ToInt32(userInput);
                    int result = number + number2;

                    Console.WriteLine("Result = {0}", result);

                    number2 = result;

                    continue;
                }

                break;
            }
            
        }
    }
}
