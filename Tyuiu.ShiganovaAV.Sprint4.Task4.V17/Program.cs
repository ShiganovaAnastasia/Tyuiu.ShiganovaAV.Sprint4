using Tyuiu.ShiganovaAV.Sprint4.Task4.V17.Lib;
namespace Tyuiu.ShiganovaAV.Sprint4.Task4.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 |Выполнила: Шиганова А.В.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнила: Шиганова Анастасия Владимировна |ПИНб-25-1|                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5] {
                { 2, 3, 2, 4, 3 },
                { 4, 7, 4, 2, 2 },
                { 5, 2, 3, 4, 6 },
                { 5, 2, 7, 6, 5 },
                { 6, 3, 5, 7, 7 }
            };
            Console.WriteLine("* ИСХОДНЫЙ МАССИВ:                                                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(matrix);

            Console.WriteLine("Сумма четных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}

