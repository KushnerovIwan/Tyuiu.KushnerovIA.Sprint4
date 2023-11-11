using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KushnerovIA.Sprint4.Task6.V1.Lib;

namespace Tyuiu.KushnerovIA.Sprint4.Task6.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнил: Кушнеров И. А. | ПКТБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант 1                                                               *");
            Console.WriteLine("* Выполнил: Кушнеров Иван Антонович   | ПКТБ-23-2                         *"); 
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных, используя класс Array подсчитайте           ");
            
            Console.WriteLine("* количество элементов, длина которых больше 6.                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] companies = { "Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };

            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i < companies.Length; i++)
            {
                Console.WriteLine(companies[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(companies);

            Console.WriteLine("Количество элементов с длиной больше 6: " + result);
            Console.ReadKey();
        }
    }
}