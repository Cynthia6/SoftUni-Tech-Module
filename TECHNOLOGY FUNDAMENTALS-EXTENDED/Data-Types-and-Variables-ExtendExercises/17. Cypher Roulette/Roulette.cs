
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace _17.Cypher_Roulette
{
    //You will be given an integer N.On the next N lines, you will receive some strings.
    //The strings will be either:
    //•	sequences of random characters
    //•	or the command - "spin"

    //If they are normal random characters, you should append them to one another in the cypher string.
    //If the command "spin" is entered, every string entered after it should be appended at the start
    //of the cypher string, if the command "spin" is entered again after that, you should again begin to append
    //them at the end of the cypher string. And so, the append direction changes each time you enter the command "spin".
    //If two equal strings are entered two consecutive times, the cypher resets - emptying the cypher string. This rule also applies to the "spin" command.
    //Note: the "spin" commands do not count towards the N count.

    class Roulette
    {
        static void Main(string[] args)
        {
            uint inputRows = uint.Parse(Console.ReadLine());

            string cypherString = "", currString, prevString = "";
            string concatMode = "NormalMode";

            while (inputRows > 0)
            {
                currString = Console.ReadLine();

                if (prevString == currString)
                {
                    cypherString = string.Empty;

                    if (prevString != "spin")
                        inputRows--;

                    continue;
                }

                if (currString != "spin")
                    inputRows--;

                else
                {
                    if (concatMode == "SpinMode")
                        concatMode = "NormalMode";

                    else
                        concatMode = "SpinMode";

                    prevString = currString;
                    continue;
                }

                switch (concatMode)
                {
                    case ("NormalMode"):
                        cypherString = cypherString + currString;
                        break;

                    case ("SpinMode"):
                        cypherString = currString + cypherString;
                        break;
                }

                prevString = currString;

            }
            Console.WriteLine(cypherString);
        }
    }
}