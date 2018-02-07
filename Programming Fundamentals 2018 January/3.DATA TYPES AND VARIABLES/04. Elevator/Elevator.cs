using System;
//Calculate how many courses will be needed to elevate n persons by using an elevator of capacity of p persons. 
//The input holds two lines: the number of people n and the capacity p of the elevator.


namespace _04.Elevator
{
    class Elevator
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling((double)n / p);
            //  if (n % p != 0) courses += 1;

            Console.WriteLine((int)courses);
        }
    }
}
