using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter2_7
{
    class Program
    {
        static bool Echo(string message)
        {
            Console.WriteLine(message);
            return true;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("ショートサーキット評価なし");
            var x = Echo("a") | Echo("b");

            Console.WriteLine("ショートサーキット評価あり");
            var y = Echo("a") || Echo("b");
        }
    }
}
