using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KoevaSJ.Sprint1.Task5.V4.Lib;

namespace Tyuiu.KoevaSJ.Sprint1.Task5.V4
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
            Console.WriteLine("* Задание #5                                                                 *");
            Console.WriteLine("* Вариант #4                                                                 *");
            Console.WriteLine("* Выполнила: Коева Софья Юрьевена | АСОиУБ-23-1                              *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая решает задачу                                  *");
            

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            int k;

            Console.WriteLine("Введите количество секунд k: ");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine($" Прошло {ds.SecondsToHours(k)} полных часа");
            Console.ReadKey();


        }
    }
}
