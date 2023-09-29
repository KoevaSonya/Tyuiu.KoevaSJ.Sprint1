using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KoevaSJ.Sprint1.Task7.V18.Lib;

namespace Tyuiu.KoevaSJ.Sprint1.Task7.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Коева С. Ю. | АСОиУБ-23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                  *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                           *");
            Console.WriteLine("* Задание #7                                                                 *");
            Console.WriteLine("* Вариант #18                                                                *");
            Console.WriteLine("* Выполнила: Коева Софья Юрьевена | АСОиУБ-23-1                              *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение             *");
            Console.WriteLine("*  по исходным значениям данных, вводимых пользователем.                     *");

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("             1 + Sin( x + y )^2                                              *");
            Console.WriteLine("  z =  -------------------------------- + x                                  *");
            Console.WriteLine("             |        2*x        |                                           *");
            Console.WriteLine("         2+  | x - ------------- |                                           *");
            Console.WriteLine("             |    1 + x^2 * y^2  |                                           *");

            double x, y;

            Console.WriteLine("Введите значение Х:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();

        }
    }
}
