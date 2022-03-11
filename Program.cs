using System;

namespace MaximumGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greeting Meesage
            Console.WriteLine("Welcome to Generic Program.");

            //User Input
            Console.WriteLine("Welcome to the Generics programs");
            Console.Write("Enter First Number : ");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int secondValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number : ");
            int thirdValue = Convert.ToInt32(Console.ReadLine());
            //printing Output
            int resultNum = FindMaximum.ThreeMaxIntNumber(firstValue, secondValue, thirdValue);
            Console.WriteLine("{0} is maximum value from first: {1} second: {2} third: {3}", resultNum, firstValue, secondValue, thirdValue);
            Console.ReadLine();
        }
    }
}