using System;

namespace _15.Calculator
{
    //  Create a program that reads 3 lines:
    //•	An operand.
    //•	An operator.
    //•	A second operand.
    //And performs the operation between the operands.The left and right operands will always be integers

    public class Calculators
    {
        public static void Main()
        {

            int operator1 = int.Parse(Console.ReadLine());
            char operand = char.Parse(Console.ReadLine());
            int operator2 = int.Parse(Console.ReadLine());

           int result=  Calculator1(operator1, operand, operator2);

            Console.WriteLine( $" {operator1} {operand} {operator2} = {result}");



        }

        private static int Calculator1(int operator1, char operand, int operator2)
        {
            int result = 0;
            switch (operand)
               
            {
                case '-':
                result = operator1 - operator2;
                break;
                case '+':
                result = operator1 + operator2;
                break;
                case '*':
                result = operator1 * operator2;
                break;
                case '/':
                result = operator1 / operator2;
                break;

                default:
                    Console.WriteLine("error");
                    break;
            }
            return result;
        }
        
    }
}
