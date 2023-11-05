﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GofmanDV.Sprint4.Task3.V4.Lib;

namespace Tyuiu.GofmanDV.Sprint4.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] nArray = { { 6, 5, 4, 1, 5 }, { 8, 2, 3, 4, 2 }, { 3, 7, 7, 1, 3 }, { 3, 4, 8, 1, 3 }, { 4, 3, 5, 5, 2 } };
            int wait = 15;
            int res = ds.Calculate(nArray);

            Assert.AreEqual(wait, res);
        }
    }
}