using System;
using Tyuiu.ShiganovaAV.Sprint4.Task0.V18.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.ShiganovaAV.Sprint4.Task0.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 |Выполнила: Шиганова А.В.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Шиганова Анастасия Владимировна |ПИНб-25-1|                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[] numsArray = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine(numsArray[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.GetSumOddArrEl(numsArray);
            Console.WriteLine(res);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

