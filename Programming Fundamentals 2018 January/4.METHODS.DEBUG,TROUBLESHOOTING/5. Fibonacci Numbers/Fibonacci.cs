using System;
//Define a method Fib(n) that calculates the n th Fibonacci number.
namespace _5.Fibonacci_Numbers
{
    class Fibonacci
    {
        static int Fib(int n)
        {
            int firstNumber = 1;
            int secondNumber = 1;
            for (var i = 0; i < 100; i++)
            {

                int fNext = firstNumber + secondNumber;

                if (i == n)
                {
                    return firstNumber;
                }
                firstNumber = secondNumber;
                secondNumber = fNext;


            }

            return n;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int neededNum = Fib(n);


            Console.WriteLine(neededNum);
            //int n = int.Parse(Console.ReadLine());
            //int firstNumber = 1;
            //int secondNumber = 1;
            //for (var i = 0; i < n - 1; i++)
            //{
            //    int fNext = firstNumber + secondNumber;
            //    firstNumber = secondNumber;
            //    secondNumber = fNext;
            //}
            //Console.WriteLine(secondNumber);





        }
    }
}