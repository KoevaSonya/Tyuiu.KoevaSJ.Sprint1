using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoevaSJ.Sprint1.Task7.V18.Lib;

namespace Tyuiu.KoevaSJ.Sprint1.Task7.V18.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void Validexpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 1.392;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
