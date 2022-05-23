using System;

namespace ch07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The quick brown");
            Console.WriteLine("fox jumps");
            Console.Write("over the");
            Console.WriteLine("lazy dog");

            // either
            string input = Console.ReadLine();

            int parsedInput = int.Parse(input);
            Console.WriteLine($"Int is: {parsedInput}");

            //or
            string input2 = Console.ReadLine();

            double parsedInput2 = Double.Parse(input2);
            Console.WriteLine($"Double is: {parsedInput2}");
        }
    }
}
