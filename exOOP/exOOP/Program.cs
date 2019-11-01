using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint v1 = new MyPoint(2, 5);
            MyPoint v2 = new MyPoint(3, 4);
            MyPoint v3 = new MyPoint(5, 8);
            Tritangle tg = new Tritangle(v1, v2, v3);
            Console.WriteLine(tg.Type());
        }
    }
}
