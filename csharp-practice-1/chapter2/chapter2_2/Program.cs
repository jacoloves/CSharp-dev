using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            a = 5;
            b = 10;

            int c;
            c = a + b;
            Console.WriteLine("a: {0}, b: {1}, c: {2}", a, b, c);

            a = 10;
            Console.WriteLine("a: {0}, b: {1}, c: {2}", a, b, c);
        }
    }
}
