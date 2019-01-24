using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                if(a>0 && a%2==1) sum+=a;
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
