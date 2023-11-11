using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KushnerovIA.Sprint4.Task3.V7.Lib;

namespace Tyuiu.KushnerovIA.Sprint4.Task3.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Кушнеров И. А. | ПКТБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Кушнеров Иван Антонович   | ПКТБ-23-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 9. Подсчитайте количество   *");
            Console.WriteLine("* нечетных элементов во всем массиве.                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] arrayNums = new int[5, 5] { { 9, 6, 9, 3, 7 },
                                               { 3, 3, 3, 8, 2 },
                                               { 2, 1, 3, 5, 2 },
                                               { 6, 2, 3, 2, 5 },
                                               { 4, 5, 6, 9, 5 } };

            Console.WriteLine("Массив:");
            for (int i = 0; i < arrayNums.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNums.GetLength(1); j++)
                {
                    Console.Write($"{arrayNums[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество четных элементов = " + ds.Calculate(arrayNums));

            Console.ReadLine();
        }
    }
}
