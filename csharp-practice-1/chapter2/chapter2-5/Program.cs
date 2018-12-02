using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 1;
            var y = 2;

            string s = string.Format("{0} + {1} = {2}", x, y, x + y);
            string t = $"{x} + {y} = {x + y}";

            Console.WriteLine(t);
        }
    }
}
