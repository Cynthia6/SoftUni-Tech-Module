using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            ReceiptFull();
            
        }
        public static void Header()
        {
        Console.WriteLine("CASH RECEIPT\n------------------------------");

        }
        public static void Body()
        {
        Console.WriteLine("Charged to____________________\nReceived by___________________");

        }
        public static void Footer()
        {
            Console.WriteLine("------------------------------\n\u00A9 SoftUni");

        }
        public static void ReceiptFull()
        {
            Header();
            Body();
            Footer();

        }
    }
}
