using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List9_Imp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rect2 = new[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
            };

            Console.WriteLine(rect2[2, 2]);
        }
    }
}
