using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Calculator
{
  //  Create a program that reads 3 lines:
//•	An operand.
//•	An operator.
//•	A second operand.
//And performs the operation between the operands.The left and right operands will always be integers

    class Calculators
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            char operatori = char.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            decimal result = Calculator(number1, operatori, number2);

            Console.WriteLine($"{number1} {operatori} {number2} = {result}");
        }

        public static int Calculator(int number1, char operatori, int number2)
        {
            int result = 0;
            switch (operatori)
            {
                case '-':
                    result = number1 - number2;
                    break;
                case '+':
                    result = number1 + number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

            return result;

        }
    }
}
