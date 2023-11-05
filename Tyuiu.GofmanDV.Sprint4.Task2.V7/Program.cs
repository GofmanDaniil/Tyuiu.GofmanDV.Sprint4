using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GofmanDV.Sprint4.Task2.V7.Lib;
namespace Tyuiu.GofmanDV.Sprint4.Task2.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Гофман Д. В. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант 7                                                               *");
            Console.WriteLine("* Выполнил: Гофман Даниил Викторович | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 2 до 9 подсчитать сумму нечетных элементов    *");
            Console.WriteLine("* массива.                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите количество элементов массива: ");

            int len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];

            for (int i = 0; i < len; i++) array[i] = rnd.Next(4, 9);

            Console.WriteLine("Массив: ");

            for (int i = 0; i < array.Length; i++) Console.Write(array[i] + "\t");


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
