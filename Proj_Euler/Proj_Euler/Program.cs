using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            Console.WriteLine(Utilities.Utilities.isPrime(4));
            Console.WriteLine(Problems.Problems.Problem1(1000));
            Console.WriteLine(Problems.Problems.Problem2());
            Console.WriteLine(Problems.Problems.Problem3(600851475143));
            Console.WriteLine(Problems.Problems.Problem4(999, 999));
            Utilities.Utilities.GetInt(4);
            Console.ReadLine();
        }
    }
}
