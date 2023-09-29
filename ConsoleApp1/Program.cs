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
            int y = 0, x = 0;

            x = Convert.ToInt32(Console.ReadLine());

            y = x + 1;

            Console.WriteLine(x * x);

            return;

            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
