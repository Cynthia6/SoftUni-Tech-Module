using System;
//marketing company wants to keep record of its employees.Each record would have the following characteristics:
// First name
// Last name
// Age (0...100)
// Gender(m or f)
// Personal ID number(e.g. 8306112507)
// Unique employee number(27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
//Use descriptive names.Print the data at the console.

namespace _8.Employee_Data
{
    class Employee
    {
        static void Main()
        {
            string name = "Amanda";
            string last = "Jonson";
            short age = 27;
            char s1 = 'f';
            long id = 8306112507;
            int emplNum = 27563571;


            Console.WriteLine("First name: " + name);
            Console.WriteLine("Last name: " + last);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + s1);
            Console.WriteLine("Personal ID: " + id);
            Console.WriteLine("Unique Employee number: " + emplNum);
        }
    }
}
