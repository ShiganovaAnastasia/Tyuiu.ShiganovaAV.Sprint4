using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShiganovaAV.Sprint4.Task6.V10.Lib
{
    public class DataService : ISprint4Task6V10
    {
        public string[] Calculate(string[] array)
        {
            return Array.FindAll(array, element => element.Length < 7);
        }
    }
}
