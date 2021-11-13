using System;
using System.Linq;
namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number : ");
            int number = int.Parse(Console.ReadLine());

            int sum = number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray().Sum();

            Console.WriteLine($"The Sum of Digits is : {sum}");
            Console.ReadKey();
        }
    }
}