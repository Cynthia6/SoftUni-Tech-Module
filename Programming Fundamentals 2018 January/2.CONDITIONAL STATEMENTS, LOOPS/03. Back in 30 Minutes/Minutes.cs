using System;
//Every time Stamat tries to pay his bills he sees on the cash desk the sign: "I will be back in 30 minutes". One day
//Stamat was sick of waiting and decided he needs a program, which prints the time after 30 minutes.That way he
//won’t have to wait on the desk and come at the appropriate time.He gave the assignment to you, so you have to do it.

namespace _03.Back_in_30_Minutes
{
    class Minutes
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 30;
            if ((minutes) > 59)
            {
                minutes -= 60;
               
                if (hours == 23) hours = 0;
                else  hours++;
            }
         
            Console.WriteLine($"{hours}:{minutes:D2}");

        }
    }
}
