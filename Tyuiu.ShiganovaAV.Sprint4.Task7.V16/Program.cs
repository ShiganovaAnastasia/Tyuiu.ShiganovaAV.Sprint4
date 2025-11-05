using Tyuiu.ShiganovaAV.Sprint4.Task7.V16.Lib;
namespace Tyuiu.ShiganovaAV.Sprint4.Task7.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 |Выполнила: Шиганова А.В.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнила: Шиганова Анастасия Владимировна |ПИНб-25-1|                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string value = "382976421897948";
            int n = 5;
            int m = 3;

            Console.WriteLine("Строка: " + value);
            Console.WriteLine("Количество строк (n): " + n);
            Console.WriteLine("Количество столбцов (m): " + m);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(n, m, value);
            Console.WriteLine("Произведение четных чисел = " + result);
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}

