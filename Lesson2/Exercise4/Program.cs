using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        public static bool LogPas(string login, string pasword)
        {
            string trueLogin = "root";
            string truePasword = "GeekBrains";
            return (login==trueLogin && pasword==truePasword);
        }

        public static void myProgram(string login)
        {
            Console.WriteLine("Добро пожаловать " + login + ". Чего желаете?");
            string a;
            do { a = Console.ReadLine(); }
            while (a != "exit");
        }
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("Введите логин");
                string login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string pasword = Console.ReadLine();
                if (LogPas(login, pasword)) { myProgram(login); break; }
                else { Console.WriteLine("Не верно введен логин или пароль"); }
                i++;
            }
            while (i<3);
        }
    }
}
