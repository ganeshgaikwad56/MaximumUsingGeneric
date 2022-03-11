using System;

namespace MaximumGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the finding maximum number program using generics");

            while (true)
            {
                Console.WriteLine("1: Find Max Of Three Int Number" + "\n2: Find Max Of Three Float Number" + "\n3.Exit");

                Console.Write("Enter your choice From");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int firstIntValue = 50, secondIntValue = 20, thirdIntValue = 10;
                        int resIntNum = MaxThreenumber.MaxIntNumThree(firstIntValue, secondIntValue, thirdIntValue);
                        Console.WriteLine("{0} is maximum value from first: {1} second: {2} third: {3}", resIntNum, firstIntValue, secondIntValue, thirdIntValue);
                        Console.ReadLine();
                        break;
                    case 2:
                        float firstFtVal = 2.2f, secondFtVal = 3.4f, thirdFtVal = 3.2f;
                        float resFtNum = MaxThreenumber.MaxFloatNumThree(firstFtVal, secondFtVal, thirdFtVal);
                        Console.WriteLine("{0} is maximum value from first: {1} second: {2} third: {3}", resFtNum, firstFtVal, secondFtVal, thirdFtVal);
                        Console.ReadLine();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Choose correct choice");
                        break;
                }
            }
        }
    }
}