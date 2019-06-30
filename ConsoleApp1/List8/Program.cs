using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List8
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate();
        }

        private static void Calculate()
        {
            var x = 10;
            var y = 20;
            Console.WriteLine($"In {nameof(Calculate)} method:");
            Console.WriteLine($"{nameof(x)} = {x}");
            Console.WriteLine($"{nameof(y)} = {y}");
            Console.WriteLine($"{nameof(x)} + {nameof(y)} = {x + y}");
        }
    }
}
