using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter1_2
{
    class Program
    {
        static int Echo(int x)
        {
            Console.WriteLine(x);
            return x;
        }

        static void Main(string[] args)
        {
            var s = Echo(2) + Echo(3) * Echo(4);
            Console.WriteLine(s);
        }
    }
}
