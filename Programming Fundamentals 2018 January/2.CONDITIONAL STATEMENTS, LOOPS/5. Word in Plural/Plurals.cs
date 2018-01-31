using System;
//Write a program, which receives a noun and prints the noun in plural. You will receive one of the following cases:
// A noun that ends in y – remove the y and add ies
// A noun that ends in o, ch, s, sh, x or z – add es at the end of the word
// In all other cases – just add s at the end

namespace _5.Word_in_Plural
{
    class Plurals
    {
        static void Main()
        {
            string word = Console.ReadLine();
            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 1);
                word = word + "ies";
            }
            else if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
            {
                word = word + "es";
            }
            else
            {
                word = word + "s";
            }
            Console.WriteLine(word);
        }
    }
}
