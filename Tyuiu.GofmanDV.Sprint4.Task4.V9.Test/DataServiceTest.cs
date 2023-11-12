﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GofmanDV.Sprint4.Task4.V9.Lib;

namespace Tyuiu.GofmanDV.Sprint4.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 9, 6, 9, 3, 7 }, { 3, 3, 3, 8, 2 }, { 2, 1, 3, 5, 2 }, { 6, 2, 3, 2, 5 }, { 4, 5, 6, 9, 5 } };
            int res = ds.Calculate(mas2);
            int wait = 40;

            Assert.AreEqual(wait, res);
        }
    }
}
