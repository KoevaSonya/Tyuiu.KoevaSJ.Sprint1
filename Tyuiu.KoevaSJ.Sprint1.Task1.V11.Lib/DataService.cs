using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KoevaSJ.Sprint1.Task1.V11.Lib
{
    public class DataService : ISprint1Task1V11
    {
        public double Calculate(double x, double y)
        {
            return 5 * x / (6 * y);
        }
    }
}
