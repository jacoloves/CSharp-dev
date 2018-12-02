using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = -50;
            if (x == 0)
                Console.WriteLine("x == 0");

            if(x < 0)
            {
                var abs = -x;
                Console.WriteLine(abs);
            }
        }
    }
}
