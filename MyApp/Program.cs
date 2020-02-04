using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            String firstNum=Console.ReadLine();
            Console.WriteLine("Enter the second number");
            String secondNum=Console.ReadLine();
            try
            {

                if (int.TryParse(firstNum, out int first) && int.TryParse(secondNum, out int second))
                {
                    Console.WriteLine(MathOperations.Division(first, second));
                }
                else
                    throw new Calculator.FormatException();
            }
            catch (Calculator.FormatException exception)
            {
                Console.WriteLine("Exception occured: " + exception.getMessage());
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("Exception occured: " + exception.Message);
            }
            Console.ReadLine();
        }
    }
}
