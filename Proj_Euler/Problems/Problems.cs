﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problems
{
    public class Problems
    {
        //Multiples of 3 and 5
        //Problem 1
        //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        //Find the sum of all the multiples of 3 or 5 below 1000.
        //Answer: 233168

        public static int Problem1(int toNumber)
        {
            int myTotal = 0;
            // go through numbers from 1 to 1000 to see if they are multiples of 3 or 5
            for (int i = 1; i < toNumber; i++)
            {
                if (((i % 3) == 0) || ((i % 5) == 0))
                {
                    myTotal = myTotal + i;
                }
            }
            return myTotal;

        }

        //Even Fibonacci numbers 
        //Problem 2
        //Each new term in the Fibonacci sequence is generated by adding the previous two terms.By starting with 1 and 2, the first 10 terms will be:
        //1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
        //Answer: 4613732

        public static int Problem2(int maxnum)
        {
            int fib1 = 1;
            int fib2 = 2;
            int fibeventotal = 0;
           // maxnum = 4000000;

            //go through all even fibonacci numbers and add them together
            do
            {
                //check if first number is even
                // Console.WriteLine(fib1 + " " + fib2);
                if ((fib1 % 2) == 0)
                {
                    // if even add to fibeventotal
                    //  Console.WriteLine(fib1);
                    fibeventotal = fibeventotal + fib1;
                }
                if ((fib2 % 2) == 0)
                {
                    // Console.WriteLine(fib2);
                    fibeventotal = fibeventotal + fib2;
                }
                fib1 = fib1 + fib2;
                fib2 = fib2 + fib1;
            } while (fib1 < maxnum);

            return fibeventotal;
        }


        //Largest prime factor
        //Problem 3
        //The prime factors of 13195 are 5, 7, 13 and 29.
        //What is the largest prime factor of the number 600851475143 ?
        //Answer: 6857 
        public static int Problem3(long inNumber)
        {
            int myProblem3 = Utilities.Utilities.LargestPrimeFactor(inNumber);
            return myProblem3;
        }

        //Largest palindrome product
        //Problem 4A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        //Find the largest palindrome made from the product of two 3-digit numbers.
        //Answer: 906609 
        public static int Problem4(int startnumA, int startnumB)
        {
            int islargest = 0;
            int anum;
            //start at largest two 3 digit ints to get largest product to test for palindrome


            // decrement x and then y and multiply, storing largest palindrome product
            for (int x = startnumA; x > 0; x--)
            {
                for (int y = startnumB; y > 0; y--)
                {
                    anum = x * y;
                    if (Utilities.Utilities.IsPalindrome(anum.ToString()) && anum != 0)
                    {
                        if (islargest < anum) islargest = anum;
                    }

                }

            }
            return islargest;
        }

        //Special Pythagorean triplet
        //Problem 9
        //A Pythagorean triplet is a set of three natural numbers, a < b<c, for which,
        //a2 + b2 = c2
        //For example, 32 + 42 = 9 + 16 = 25 = 52.
        //There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        //Find the product abc.

    }
}
