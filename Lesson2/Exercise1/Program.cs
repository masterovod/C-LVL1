using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        public static int Minimum(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Minimum(10, 2, 3));
            Console.ReadKey();
        }
    }
}
