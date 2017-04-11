using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4Phone
{
    class Phone
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ').ToArray();
            string[] contactName = Console.ReadLine().Split(' ').ToArray();

            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "done")
            {
                if (command[0] == "call")
                {
                    PrintCallCommand(phoneNumbers, contactName, command);
                }
                else if (command[0] == "message") 
                {
                    PrintMessageCommand(phoneNumbers, contactName, command);
                }
                command = Console.ReadLine().Split(' ').ToArray();

            }
        }
        private static int CalculateSumOfDigits(string phones, int sumDigits)
        {
            char[] sum = phones.ToCharArray();
            for (int i = 0; i < sum.Length; i++)
            {
                if((int)sum[i] < 58 && (int)sum[i] >= 49)
                sumDigits += int.Parse(sum[i].ToString());
            }
            return sumDigits;
        }
        
        private static void PrintMessageCommand(string[] phones, string[] names, string[] command)
        {
            int sum = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (command[1] == names[i])
                {
                    Console.WriteLine("sending sms to {0}...", phones[i]);
                    sum = CalculateSumOfDigits(phones[i], sum);
                    if (sum % 2 == 0) Console.WriteLine("meet me there");
                    else Console.WriteLine("busy");
                }
                if (command[1] == phones[i])
                {
                    Console.WriteLine("sending sms to {0}...", names[i]);
                    sum = CalculateSumOfDigits(phones[i], sum);
                    if (sum % 2 == 0) Console.WriteLine("meet me there");
                    else Console.WriteLine("busy");
                }

            }

        }

        private static void PrintCallCommand(string[] phones, string[] names, string[] command)
        {
            int sum = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (command[1] == names[i])
                {
                    Console.WriteLine("calling {0}...", phones[i]);
                    sum = CalculateSumOfDigits(phones[i], sum);
                    int m = sum / 60;
                    int s = sum % 60;
                    if (sum % 2 == 0) Console.WriteLine("call ended. duration: {0:00}:{1:00}", m, s);
                    else Console.WriteLine("no answer");
                }
                else if (command[1] ==phones[i])
                {
                    Console.WriteLine("calling {0}...",names[i]);
                    sum = CalculateSumOfDigits(phones[i], sum);
                    int m = sum / 60;
                    int s = sum % 60;
                    if (sum % 2 == 0) Console.WriteLine("call ended. duration: {0:00}:{1:00}", m, s);
                    else Console.WriteLine("no answer");
                }
                
            }
        }
        
    }
}