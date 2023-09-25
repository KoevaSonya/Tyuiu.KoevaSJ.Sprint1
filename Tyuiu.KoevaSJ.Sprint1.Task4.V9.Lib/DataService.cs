using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KoevaSJ.Sprint1.Task4.V9.Lib
{
    public class DataService : ISprint1Task4V9
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round(Math.Log(x * y) / x - (Math.Sqrt(1 + (Math.Pow(y, 2)))),3);
            return res;
        }
    }
}
