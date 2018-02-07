using System;
//Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it
//with the concatenation of the first two variables(mind adding an interval between). Declare a third string variable
//and initialize it with the value of the object variable(you should perform type casting).

namespace _6.Strings_And_Objects
{
    class StringsObjects
    {
        static void Main()
        {
            string greetings = "Hello";
            string word = "World";
            object con = greetings + " " + word;

            Console.WriteLine(con);
        }
    }
}
