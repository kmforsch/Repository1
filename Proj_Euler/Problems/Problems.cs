using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problems
{
    public class Problems
    {
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
        //Get the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
        public static int Problem2()
        {
            int fib1 = 1;
            int fib2 = 2;
            int fibeventotal = 0;
            int maxnum = 4000000;

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

        public static int Problem3(long inNumber)
        {
            int myProblem3 = Utilities.Utilities.LargestPrimeFactor(inNumber);
            return myProblem3;
        }

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
    }
}
