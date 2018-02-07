using System;
////Create a method that prints a blank cash receipt. The method should invoke three other methods: one for printing
//the header, one for the body and one for the footer of the receipt.

namespace _01.Blank_Receipt
{
    class Receipt
    {
        static void Main()
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