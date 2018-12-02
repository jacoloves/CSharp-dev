using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("整数を入力してください：");
            var x = int.Parse(Console.ReadLine());
            var y = x * x;
            Console.WriteLine($"{x} × {x} = {y}");
        }
    }
}
