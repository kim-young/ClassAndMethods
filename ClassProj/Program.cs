using System;

namespace ClassProj
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
			int number = int.Parse(Console.ReadLine());

			Console.WriteLine(Class.Addition(number));
			Console.WriteLine(Class.Subtract(number));
			Console.WriteLine(Class.Multiply(number));
        }
    }
}
