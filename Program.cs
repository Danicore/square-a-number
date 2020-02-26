using System;

namespace SquareANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string str = Console.ReadLine();
            int a = Convert.ToInt32(str);
            Console.WriteLine(a * a);
            Console.Read();
        }
    }
}
