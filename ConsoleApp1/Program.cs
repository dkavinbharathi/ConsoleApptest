using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p =new Program();
           int r= p.testing();
           Console.WriteLine("Hello world:" +r);
        }

        public int testing()
        {
            //comments
            int a = 12;
            int b = 12;
            int c = a + b;
            return c;
        }
    }
}
