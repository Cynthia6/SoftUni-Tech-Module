using System;

namespace _6.Notification
{
    public class notification
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                string operation = Console.ReadLine();
                string operation1, message = string.Empty;
                int number = 0;
                if (operation == "success")
                {
                     operation1 = Console.ReadLine();
                     message = Console.ReadLine();
                    Console.WriteLine(ShowSuccess(operation1, message));

                }
               else if (operation == "error")
                {
                    operation1 = Console.ReadLine();
                    number = int.Parse(Console.ReadLine());
                    if (number < 0)
                    {
                         message = "Internal System Failure";
                    }
                    else
                    {
                        message = "Invalid Client Data";
                    }
                    Console.WriteLine(ShowError(operation1, number, message));

                }
               else
                {
                    continue;
                }
                
               
            }

        }
        public static string ShowSuccess(string operation, string message)
        {
           return $"Successfully executed {operation}.\n==============================\nMessage: {message}.";

        }
        public static string ShowError(string operation, int code, string message)
        {
            return $"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: {message}.";
  
        }

    }
}
