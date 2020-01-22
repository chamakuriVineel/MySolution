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
            Console.WriteLine(Calculator.MathOperations.Division(5,0));
            Console.ReadLine();
        }
    }
}
