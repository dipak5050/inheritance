using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class a
    {
        public void ex()
        {
            Console.WriteLine("a");
        }
    }
    class b:a
    {
        public void ex()
        {
            Console.WriteLine("b");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            a aa=new a();
            aa.ex();
            b bb = new b();
            bb.ex();

            Console.ReadKey();
        }
    }
}
