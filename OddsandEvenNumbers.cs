using System;

namespace Rozpoznawanie_rodzaju_liczb
{
    class Program
    {
       
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a number: \n");
                    int oddOrEven = int.Parse(Console.ReadLine());

                    if (oddOrEven % 2 == 0)
                    {
                        Console.WriteLine("\nNumber {0} is an even number.\n", oddOrEven);
                        break;
                    }
                    if (oddOrEven % 2 != 0)
                    {
                        Console.WriteLine("Number {0} is an odd number.\n", oddOrEven);
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nGiven data is not valid.\n");
                }
            }
            Console.ReadKey();
        }
    }
}
