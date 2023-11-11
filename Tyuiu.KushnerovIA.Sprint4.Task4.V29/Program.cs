using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KushnerovIA.Sprint4.Task4.V29.Lib;

namespace Tyuiu.KushnerovIA.Sprint4.Task4.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Кушнеров И. А. | ПКТб-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Кушнеров Иван Антонович | ПКТб-23-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 4 до 8.                          *");
            Console.WriteLine("* Найдите сумму   четных элементов массива.                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            int str = 5;
            int stl = 5;
            int[,] array = new int[str, stl];

            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stl; j++)
                {
                    Console.WriteLine($"Введите {i},{j} элемент массива:");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }


            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Массив:\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "  ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма чётных элементов = {ds.Calculate(array)}");
            Console.ReadKey();
        }
    }
}
 
