using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GofmanDV.Sprint4.Task3.V4.Lib
{
    public class DataService : ISprint4Task3V4
    {
        public int Calculate(int[,] array)
        {
            int summa = 0;
            int c = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    c++;
                    if (c == 5)
                    {
                        summa += array[i, j];
                        c = 0;
                    }
                }
            }
            return summa;
        }
    }
}
