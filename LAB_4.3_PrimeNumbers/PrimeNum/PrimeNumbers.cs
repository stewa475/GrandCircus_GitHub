using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNum
{
    public class PrimeNumbers
    {

        //private static int[] seq = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
        public static int GetPrime(int n)
        {
            //return seq[n - 1];

            int count = 0;
            int prime = 1;
            do
            {
                prime++;
                if (PrimeCheck(prime))
                {
                    count++;
                }
            } while (count < n);
            return prime;
        }


        public static bool PrimeCheck(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }

}


