using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            Console.WriteLine("**********Introduce one number between 1 and 10**********");
            n = Console.ReadLine();
            Console.WriteLine("*************************************");
            Multiplica(int.Parse(n));
            Console.ReadLine();
        }

        static void Multiplica(int num)
        {
            int res = 1;
            for (int i = 1; i < 11; i++)
            {
                res = num * i;
                Console.WriteLine(num + "   *   " + i + "   =   "+ res);
            }
        }
    }
}
