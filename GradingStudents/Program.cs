using System;
using System.Collections.Generic;

namespace GradingStudents
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // list of students & their grades
                var students = new List<Student>
                {
                    new Student
                    {
                        Grade = 73
                    },
                    new Student
                    {
                        Grade = 67
                    },
                    new Student
                    {
                        Grade = 38
                    },
                    new Student
                    {
                        Grade = 33
                    },
                    new Student
                    {
                        Grade = 0
                    }
                };

                // create the grading logic object & perform the grading
                var gradingLogic = new GradingLogic(students);
                var roundedGrades = gradingLogic.PerformGrading();

                // show the results
                foreach (var roundedGrade in roundedGrades)
                {
                    Console.WriteLine(roundedGrade);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.ReadLine();
            }


        }
    }
}
