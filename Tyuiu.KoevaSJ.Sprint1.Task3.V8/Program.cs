using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KoevaSJ.Sprint1.Task3.V8.Lib;

namespace Tyuiu.KoevaSJ.Sprint1.Task3.V8
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
            Console.WriteLine("* Задание #3                                                                 *");
            Console.WriteLine("* Вариант #8                                                                 *");
            Console.WriteLine("* Выполнила: Коева Софья Юрьевена | АСОиУБ-23-1                              *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу вычисления величины дохода по вкладу.                   *");
            Console.WriteLine("* Процентная ставка (% годовых) и время хранения (дней) задаются             *");
            Console.WriteLine("* во время работы в программы.                                               *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            double startAmount;
            Console.WriteLine("Введите величину вклада (руб.): ");
            startAmount = Convert.ToDouble(Console.ReadLine());

            double timeDays;
            Console.WriteLine("Введите cрок вклада: ");
            timeDays = Convert.ToDouble(Console.ReadLine());

            double percent;
            Console.WriteLine("Введите процентную ставку: ");
            percent = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            double income = ds.IncomeAmount(startAmount, percent, timeDays);
            double profit = Math.Round(income - startAmount, 2);

            Console.WriteLine("Доход: " + profit);
            Console.WriteLine("Сумма по окончании срока вклада: " + income);
            Console.ReadLine();
        }
    }
}
