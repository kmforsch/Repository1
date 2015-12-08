using System;
using System.Collections.Generic;

namespace Utilities
{
    public class Utilities
    {

        public static Boolean isPrime(long number1)
        {
            long i;
            Boolean isPrimeVar = false;
            if (number1 < 1) return isPrimeVar;
            for (i = 2; i < number1; i++)
            {
                // if at any time it is evenly divisible it is not a prime number, stop evaluating
                if (number1 % i == 0)
                {
                    return isPrimeVar = false;
                }
            }
            //if (i == number1)
            //{
            //    if you get this far and the number is divisible by itself then return true
            isPrimeVar = true;
            //}
            return isPrimeVar;

        }
        public static void PrimeNumbers(long number)
        {
            int counter = 0;

            for (long i = 2; i <= number; i++)
            {
                long sqRootNumber = Convert.ToInt64(Math.Sqrt(Convert.ToInt64(i)));
                Boolean isPrime = true;
                for (long j = 2; j <= sqRootNumber; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    //keep incrementing number of prime numbers
                    counter = counter + 1;
                    Console.WriteLine(i + " counter: " + counter);
                }
            }
            Console.ReadLine();
        }


        public static int LargestPrimeFactor(long num)
        {
            int answer = 0;
            List<long> result = new List<long>();

            // keep dividing by 2 until result is not an even number
            while (num % 2 == 0)
            {
                result.Add(2);
                num /= 2;
            }

            // Find all other possible factors from 3 up to the number entered 
            long factor = 3;
            while (factor * factor <= num)
            {
                if (num % factor == 0)
                {
                    // if number is a factor, divide numb by the factor to get next number to check
                    result.Add(factor);
                    num /= factor;
                }
                else
                {
                    // Check the next odd factor, even factors were handled at start
                    factor += 2;
                }
            }

            // If num is not 1, then whatever is left is prime.
            if (num > 1) result.Add(num);
            long newnum = 1;
            //write all results to console, last one is largest prime factor
            foreach (int prime in result) // Loop through List with foreach
            {
                newnum = newnum * prime;

                answer = prime;
            }
            
            return answer;
        }

        public static Boolean IsPalindrome(string palindromeString)
        {
            string str = palindromeString.ToString().ToUpper();
            Boolean isPalindrome = false;

            if (str.Length == 1) return isPalindrome = true;


            for (int i = 0; i <= str.Length / 2 + 1; i++)
                if (str.Length >= 2)
                {
                    string stra = str.Substring(0, 1);
                    string strb = str.Substring(str.Length - 1, 1);
                    if (stra == strb)
                    {
                        if (str.Length >= 2)
                        {
                            str = str.Substring(1, str.Length - 2);
                            isPalindrome = true;
                        }
                    }
                    else
                    {
                        isPalindrome = false;
                    }
                }
            return isPalindrome;


        }

        public static int GetInt(int defaultValue)
        {
            try
            {
                string appKeyString = "";

                if (appKeyString != null)
                {

                    Console.WriteLine("Int32: " + Int32.Parse(appKeyString));
                    return Int32.Parse(appKeyString);
                }
            }
            catch (Exception exc)
            {
                System.Diagnostics.EventLog log = new System.Diagnostics.EventLog();
                System.Diagnostics.EventLog.CreateEventSource("MySource", "MyNewLog");
                Console.WriteLine("CreateEventSource");
                Console.WriteLine(exc);
                Console.ReadLine();
            }
            Console.WriteLine("default: " + defaultValue);//
            return defaultValue;
        }



    }
}
