using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KoevaSJ.Sprint1.Task1.V11.Lib;

//ЗАДАНИЕ
// Написать программу, которая запрашивает у пользователя исходные данные,
// результат по формуле 5 * x / (6 * y) и печатает его на экране.

namespace Tyuiu.KoevaSJ.Sprint1.Task1.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Коева С. Ю. | АСОиУБ-23-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                   *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                            *");
            Console.WriteLine("* Задание #1                                                                  *");
            Console.WriteLine("* Вариант #11                                                                 *");
            Console.WriteLine("* Выполнила: Коева Софья Юрьевена | АСОиУБ-23-1                               *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,     *");
            Console.WriteLine("* результат по формуле 5 * x / (6 * y) и печатает его на экране.              *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");

            double x, y;

            Console.WriteLine("Ведите значение Х:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ведите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));


            Console.ReadLine();
        }
    }
}
