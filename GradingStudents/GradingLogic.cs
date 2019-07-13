using System;
using System.Collections.Generic;

namespace GradingStudents
{
    public class GradingLogic
    {
        private readonly List<Student> _students;

        private const int FAIL_GRADE = 40;
        private const int ROUND_TO = 5;
        private const int ROUNDING_THRESHOLD = 3;

        public GradingLogic(List<Student> students)
        {
            this._students = students ?? throw new ArgumentNullException(nameof(students));
        }

        public List<int> PerformGrading()
        {
            // create the list to return
            var roundedGrades = new List<int>();

            // iterate through the students & perform the grading process
            foreach (var student in _students)
            {
                // check for fail conditions
                if (student.Grade <= FAIL_GRADE - ROUNDING_THRESHOLD)
                {
                    roundedGrades.Add(student.Grade);
                    continue;
                }

                // get the next multiple of 5
                var nextMultiple = GetNextMultipleOfN(student.Grade);

                // add the appropriate grade
                roundedGrades.Add((nextMultiple - student.Grade < ROUNDING_THRESHOLD ? nextMultiple : student.Grade));
            }

            return roundedGrades;
        }

        private int GetNextMultipleOfN(int number)
        {
            return number += (ROUND_TO - number % ROUND_TO);
        }
    }
}
