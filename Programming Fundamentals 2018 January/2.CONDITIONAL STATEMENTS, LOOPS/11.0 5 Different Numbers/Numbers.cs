using System;
//You will be given two numbers – a and b. Generate five numbers - n 1 , n 2 , n 3 , n 4, n 5 , for which the following conditions
//are true: a ≤ n 1 &lt; n 2 &lt; n 3 &lt; n 4 &lt; n 5 ≤ b.If there is no number in the given interval, which satisfies the conditions –
//print “No”.

namespace _11._0_5_Different_Numbers
{
    class Numbers
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            if (first + 5 >= second)//second - first <= 5
            {
                Console.WriteLine("No");
                return;
            }
            for (int i = first; i <= second-4; i++)
            {
                for (int j = first+1; j <= second-3; j++)
                {
                    for (int k = first+2; k <= second-2; k++)
                    {
                        for (int l = first+3; l <= second-1; l++)
                        {
                            for (int m = first+4; m <= second; m++)
                            {
                                if (i < j && j < k && k<l && l<m)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
