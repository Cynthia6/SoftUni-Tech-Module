using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program, which reads the name of a student and their grades and adds them to the student record, then prints grades along with their average grade.
namespace _01.Average_Student_Grade
{
    public class Grades
    {
        public static void Main()
        {
            var numStudents = int.Parse(Console.ReadLine());
            var studentsGrades = new Dictionary<string, List<double>>();
            for (int i = 0; i < numStudents; i++)
            {
                var gradesnames = Console.ReadLine().Split(' ');
                var name = gradesnames[0];
                var grade = double.Parse(gradesnames[1]);


                if (!studentsGrades.ContainsKey(name)) studentsGrades[name] = new List<double>();
                studentsGrades[name].Add(grade);
             }
            foreach (var kvp in studentsGrades)
            {
                Console.WriteLine("{0} -> {1} (avg: {2:f2})", kvp.Key, string.Join(" ", kvp.Value.Select(x =>string.Format("{0:f2}", x))), kvp.Value.Average());
            }
        }
    }
}
