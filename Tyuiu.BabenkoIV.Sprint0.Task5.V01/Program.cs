using Tyuiu.BabenkoIV.Sprint0.Task5.V01.Lib;
namespace Tyuiu.BabenkoIV.Sprint0.Task5.V01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a + b = " + DataService.Addition(1, 5));
            Console.WriteLine("a - b = " + DataService.Subtraction(1, 5));
            Console.WriteLine("a * b = " + DataService.Multiplication(1, 5));
            Console.WriteLine("a / b = " + DataService.Division(1, 0));
        }
    }
}
