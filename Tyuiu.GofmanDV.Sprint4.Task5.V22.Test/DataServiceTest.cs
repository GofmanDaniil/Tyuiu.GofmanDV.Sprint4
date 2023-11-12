using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GofmanDV.Sprint4.Task5.V22.Lib;

namespace Tyuiu.GofmanDV.Sprint4.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateCheck()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { {-6, -7, 3, 1, -5},
                                          {-6, 3, 2, 1, 2},
                                          {1, 3, 2, -8, 1},
                                          {-5, -2, 1, -5, 1},
                                          {3, -3, -4, -4, -6} };
            int res = ds.Calculate(mas2);
            int wait = 12;
            Assert.AreEqual(wait, res);
        }
    }
}
