using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;


                Console.WriteLine("Lets locate some Prime Numbers!");
                Console.WriteLine();
                Console.WriteLine("***This application will find you any prime, in order, from first prime number on.***");
                Console.WriteLine();
            while (keepGoing)
            {


                Console.Write("Which prime number are you looking for?:");
                int input = int.Parse(Console.ReadLine());
                PrimeNumbers PrimNum = new PrimeNumbers();
                PrimNum.IsAPrime(input);
                PrimNum.GetPrime(input);

                Console.WriteLine($"The number {input} prime is { PrimNum.GetPrime(input)}.");
                Console.WriteLine();
                Console.Write("Do you want to find another prime number? (y/n):");
                string another = Console.ReadLine().ToUpper();
                if (another == "Y" || another == "YES")
                {
                    continue;
                }
                else if (another == "N" || another == "NO")
                {
                    Console.WriteLine("Thank you for using PrimeNumbers!");
                    keepGoing = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid input. We will find another prime for you.");
                    continue;
                }
            }
        }
    }
}
