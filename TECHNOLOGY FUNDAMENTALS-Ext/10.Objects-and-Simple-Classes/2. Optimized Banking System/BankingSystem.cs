using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Optimized_Banking_System
{
    class BankAccount
    {
        public string Bank { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
    public class BankingSystem
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var accountsList = new List<BankAccount>();

            while (input != "end")
            {
                BankAccount currentAcc = ReadBankInfo(input);
                accountsList.Add(currentAcc);

                input = Console.ReadLine();
            }

            foreach (var account in accountsList.OrderByDescending(x => x.Balance).ThenBy(x => x.Bank.Length))
            {
                Console.WriteLine($"{account.Name} -> {account.Balance} ({account.Bank})");
            }
        }

        private static BankAccount ReadBankInfo(string input)
        {
            var tokens = input.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            return new BankAccount
            {
                Bank = tokens[0],
                Name = tokens[1],
                Balance = decimal.Parse(tokens[2])
            };
        }
    }
}