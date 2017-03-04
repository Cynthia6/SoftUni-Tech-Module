using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = new char[26];
            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet[i - 'a'] = i;
            }
        }
    }
}
