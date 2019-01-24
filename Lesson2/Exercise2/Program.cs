using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        public static int Nodin(int a)
        {
            int result = 0;
            while (a != 0)
            {
                result += 1;
                a = a / 10;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Nodin(136542));
            Console.ReadKey();
        }
    }
}
