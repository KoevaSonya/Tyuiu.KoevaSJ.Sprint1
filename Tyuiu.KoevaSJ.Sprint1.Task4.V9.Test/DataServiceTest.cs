using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoevaSJ.Sprint1.Task4.V9.Lib;



namespace Tyuiu.KoevaSJ.Sprint1.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 3;
            double wait = -2.541;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
