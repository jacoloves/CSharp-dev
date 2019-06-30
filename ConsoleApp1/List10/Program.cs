using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List10
{
    class Person
    {
        public string name;
        public uint age;
        public string address;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();

            p.name = "arai";
            p.age = 17;
            p.address = "http://araisanndayo.com";

            Console.WriteLine("名前:{0}", p.name);
            Console.WriteLine("年齢:{0}", p.age);
            Console.WriteLine("アドレス:{0}", p.address);

        }
    }
}
