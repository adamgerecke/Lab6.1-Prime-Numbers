using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbers
{
    public enum IsPrime
    {
        False,
        True
    }

    public class PrimeNumbers
    {
        bool isPrime = true;

        public bool IsAPrime(int x)
        {
            if (x <= 1)
            {
                isPrime = false;
                return false;
            }

            for (int i = 2; i < x; i++)
            {

                if (x % i == 0)
                {
                    isPrime = false;
                    return false;
                }

            }
            if (isPrime)
            {

            }
            isPrime = true;
            return true;



        }
        public int GetPrime(int x)
        {
            List<int> ListofPrimes = new List<int>();
            int numberTracker = 0;
            bool isPrime = false;

            while (ListofPrimes.Count <= x)
            {
                numberTracker++;
                isPrime = IsAPrime(numberTracker);
                if (isPrime)
                {
                    ListofPrimes.Add(numberTracker);
                }
            }
            return (ListofPrimes[x-1]);

        }
    }
}
