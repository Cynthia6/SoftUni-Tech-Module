using System;
//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using
//some programming logic.Print the variable values before and after the exchange, as shown below:

namespace _7.Exchange_Variable_Values
{
    class ExchangeVars
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int temp = 0;

            temp = a;
            a = b;
            b = a;

            Console.WriteLine("Before:");
            Console.WriteLine("a = 5");
            Console.WriteLine("b = 10");
            Console.WriteLine("After:");
            Console.WriteLine("a = " + b);
            Console.WriteLine("b = " + temp);
        }
    }
}
