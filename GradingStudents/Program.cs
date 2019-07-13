using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sampleGrades = new List<int>
            {
                73,
                67,
                38,
                33,
                0
            };

            var roundedGrades = GradingStudents(sampleGrades);

            foreach (var roundedGrade in roundedGrades)
            {
                Console.WriteLine(roundedGrade);
            }

            Console.ReadLine();

        }

        public static List<int> GradingStudents(List<int> grades)
        {
            var roundedGrades = new List<int>();

            foreach (var grade in grades)
            {
                // find grades under 38
                if (grade < 38)
                {
                    roundedGrades.Add(grade);
                    continue;
                }

                // get the next multiple of 5
                var nextMultiple = GetNextMultipleOfN(5, grade);

                // add the correct grade
                roundedGrades.Add((nextMultiple - grade < 3 ? nextMultiple : grade));
            }

            return roundedGrades;
        }

        public static int GetNextMultipleOfN(int n, int number)
        {
            return number += (n - number % n);
        }
    }
}
