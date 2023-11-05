using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GofmanDV.Sprint4.Task2.V7.Lib;
namespace Tyuiu.GofmanDV.Sprint4.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 4, 7, 5, 8, 8, 6, 7, 6, 5, 8, 9, 9 };
            int res = ds.Calculate(array);
            int wait = 40;
            Assert.AreEqual(wait, res);
        }
    }
}
