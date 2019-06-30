using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] rect1 =
            {
                { 4, 2, 3 },
                { 7 ,9 ,8 },
            };

            Console.WriteLine(rect1[1, 2]);
        }
    }
}
