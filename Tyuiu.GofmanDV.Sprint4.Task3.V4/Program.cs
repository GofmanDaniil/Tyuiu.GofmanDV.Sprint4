using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GofmanDV.Sprint4.Task3.V4.Lib;

namespace Tyuiu.GofmanDV.Sprint4.Task3.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] nArray = { { 6, 5, 4, 1, 5 }, { 8, 2, 3, 4, 2 }, { 3, 7, 7, 1, 3 }, { 3, 4, 8, 1, 3 }, { 4, 3, 5, 5, 2 } };
            int i_o = nArray.GetLength(0); int j_o = nArray.GetLength(1);

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Гофман Д. В. | СМАРТб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Гофман Даниил Викторович | СМАРТб-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 9.                          *");
            Console.WriteLine("* Найдите сумму элементов в последнем столбце массива.                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив: ");
            for (int i = 0; i < i_o; i++)
            {
                for (int j = 0; j < j_o; j++)
                {
                    Console.Write(" " + nArray[i, j]);
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(nArray);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
