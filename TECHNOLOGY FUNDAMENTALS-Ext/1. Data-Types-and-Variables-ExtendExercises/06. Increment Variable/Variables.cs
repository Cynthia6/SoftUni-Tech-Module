using System;

namespace _06.Increment_Variable
{
    //Write a program to increment a byte variable(starting at 0) n times and print the result.
    //If you detect an overflow (or several), print how many times there was an overflow alongside the variable value.
    public class Variables5
    {
        public static void Main()
        {
            int variable = int.Parse(Console.ReadLine());
            int overflow = 0;
            byte nums = 0;
         //   Console.WriteLine(variable%256);
          //  Console.WriteLine( variable / 256);
            for (int i = 0; i < variable; i++)
            {
                nums += 1; // nums++;
                if (nums == 0) overflow += 1;// overflow++;
            }
            if (overflow == 0) Console.WriteLine(nums);
            else
            {
                Console.WriteLine(nums);
                Console.WriteLine("Overflowed {0} times", overflow);
            }

        }
    }
}
