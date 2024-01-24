using System;

namespace Console_project
{
    class Program
    {
        private static void Main()
        {
            double number_1 = Convert.ToDouble(Console.ReadLine());
            double number_2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Math.Pow(number_1, number_2));
        }
    }
}
