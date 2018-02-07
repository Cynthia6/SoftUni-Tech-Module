using System;
//Write a method that returns the English name of the last digit of a given number. Write a program that reads an
//integer and prints the returned value from this method.

namespace _3.English_Name_of_Last_Digit
{
    class LastDigit
    {
        static void Main()
        {
            string num = Console.ReadLine();

            string numberName = numName(num);

            Console.WriteLine(numberName);

        }



        static string numName(string num)
        {
            string name = string.Empty;
            num = Convert.ToString(num[num.Length - 1]);


            switch (num)
            {
                case "0":
                    name = "zero";
                    break;
                case "1":
                    name = "one";
                    break;
                case "2":
                    name = "two";
                    break;
                case "3":
                    name = "three";
                    break;
                case "4":
                    name = "four";
                    break;
                case "5":
                    name = "five";
                    break;
                case "6":
                    name = "six";
                    break;
                case "7":
                    name = "seven";
                    break;
                case "8":
                    name = "eight";
                    break;
                case "9":
                    name = "nine";
                    break;
                default:
                    break;
            }

            return name;
        }
    }
}