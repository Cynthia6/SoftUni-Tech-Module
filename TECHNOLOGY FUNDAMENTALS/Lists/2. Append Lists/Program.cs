namespace _2.Append_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
         public static void Main()
        {
            List<string> items = Console.ReadLine().Split('|').ToList();
            items.Reverse();
            var result = new List<string>();
            foreach (var item in items)
            {
                List<string> nums = item.Split(' ').ToList();
                foreach (var num in nums)
                {
                    if (num != "") result.Add(num);
                }
            }
            
            //var input = Console.ReadLine().Split('|').ToList();
            //input.Reverse();
            //Console.WriteLine(string.Join(" ", input));

        }
    }
}
