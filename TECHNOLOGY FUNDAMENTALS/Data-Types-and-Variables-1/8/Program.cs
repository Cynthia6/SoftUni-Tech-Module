using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {

            double length, width, heigth = 0;
            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            heigth = double.Parse(Console.ReadLine());
            heigth = (length * width * heigth) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", heigth);

        }
    }
}
