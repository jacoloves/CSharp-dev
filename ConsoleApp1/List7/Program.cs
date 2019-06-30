using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abc";
            string nonNullStr = str != null ? str : "default string";
            Console.WriteLine(nonNullStr);
        }
    }
}
