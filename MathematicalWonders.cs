using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAutomation
{
    internal class MathematicalWonders
    {
        public MathematicalWonders()
        {
            Console.WriteLine("\n");
            Console.WriteLine(" ------------------TASK 3 ------------------");
            Console.WriteLine(" Enter  Fibonacci number to get the next fibonacci series");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isFibonacci(n) ? n +
                              " is a Fibonacci Number" : n +
                              " is a not Fibonacci Number");
            if (isFibonacci(n))
            {

                Console.WriteLine(" Here are the next 15 fibonacci sequence from " + n);
                GetFibonacci(n);
                Console.WriteLine();

            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine(" Enter two Fibonacci numbers to get the next fibonacci series");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isFibonacci(m) ? m +
                              " is a Fibonacci Number" : m +
                              " is a not Fibonacci Number");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isFibonacci(n) ? p +
                              " is a Fibonacci Number" : p +
                              " is a not Fibonacci Number");

            if (isFibonacci(p) && isFibonacci(m))
            {

                Console.WriteLine(" Here are the next 15 fibonacci sequence from " + m + ","+ p);
                ModGetFibonacci(m , p);

            }


        }
        static bool isPerfectSquare(int x)
        {
            int s = (int)Math.Sqrt(x);
            return (s * s == x);
        }
        static bool isFibonacci(int n)
        {
            // n is Fibonacci if one of
            // 5*n*n + 4 or 5*n*n - 4 or
            // both are a perfect square
            return isPerfectSquare(5 * n * n + 4) ||
                   isPerfectSquare(5 * n * n - 4);
        }
        static int previousFibonacci(int n)
        {
            double a = n / ((1 + Math.Sqrt(5)) / 2.0);
            return (int)Math.Round(a);
        }
        public  void GetFibonacci(int n)
        {
            int b = n;  int c = 0;
            int a = previousFibonacci(b);  // get previous fibonacci number 
            
            // For loop to print next 15 fibonocci numbers from the given number n
            for (int i = 0; i < 15; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
            

        }
        public void ModGetFibonacci(int n, int m)
        {
            int a = n; 
            int b = m; 
            int c = 0;
            for (int i = 0; i < 15; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }


        }

    }

    
}
