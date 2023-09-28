using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoevaSJ.Sprint1.Task6.V2.Lib;
//Проверить, есть ли в строке слово Hello.

namespace Tyuiu.KoevaSJ.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string s1 = "Hello, World!";
            
            Assert.AreEqual(true, ds.CheckHello(s1));



        }
    }
}
