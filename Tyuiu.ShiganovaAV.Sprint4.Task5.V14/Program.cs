using Tyuiu.ShiganovaAV.Sprint4.Task5.V14.Lib;
namespace Tyuiu.ShiganovaAV.Sprint4.Task5.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 |Выполнила: Шиганова А.В.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Шиганова Анастасия Владимировна |ПИНб-25-1|                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5] {
                { -3, 2, -5, 4, 1 },
                { 0, -2, 7, -1, 3 },
                { 5, -4, 6, 2, -3 },
                { 1, 7, -2, 0, 4 },
                { -1, 3, 5, -5, 2 }
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

            Console.WriteLine("Количество положительных элементов = " + res);
            Console.ReadKey();
        }
    }
}

