using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        public static void RecursiveA(int a, int b) {
            if (a <= b) { Console.WriteLine(a); RecursiveA(a + 1, b); }
        }
        public static int RecursiveB(int a, int b)
        {
            int sum = 0;
            if (a <= b) { return sum += a + RecursiveB(a + 1, b); } else return 0;
        }
        static void Main(string[] args)
        {
            RecursiveA(1, 10);
            Console.ReadKey();
            Console.WriteLine(RecursiveB(1, 10));
            Console.ReadKey();
        }
    }
}
