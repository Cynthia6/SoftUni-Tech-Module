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
                    string result = Console.ReadLine();
                    string operation, message = string.Empty;
                    int code = 0;

                    while (result != "success" && result != "error")
                    {
                        break;
                    }
                    if (result == "success")
                    {
                        operation = Console.ReadLine();
                        message = Console.ReadLine();
                        Console.WriteLine(ShowSuccess(operation, message));
                    }
                    if (result == "error")
                    {
                        operation = Console.ReadLine();
                        code = int.Parse(Console.ReadLine());
                        Console.WriteLine(ShowError(operation, code));
                    }

                }
            }
            public static string ShowSuccess(string operation, string message)
        {
            return $"Successfully executed {operation}.\n==============================\nMessage: {message}.";


        }
        public static string ShowError(string operation, int code)
        {
            string reason = string.Empty;
            if (code > 0)
            {
                reason = "Invalid Client Data";
            }
            else reason = "Internal System Failure";
            return $"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: {reason}.";
        }

    }
}
