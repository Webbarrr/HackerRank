using System;
using Challenges.DayOfTheProgrammer;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // test 1
            var result = DayOfProgrammer(1984);
            Console.WriteLine(result); // 12.09.1984

            // test 2
            result = DayOfProgrammer(2017);
            Console.WriteLine(result); // 13.09.2017

            // test 3
            result = DayOfProgrammer(2016);
            Console.WriteLine(result); // 12.09.2016

            // test 4
            result = DayOfProgrammer(1800);
            Console.WriteLine(result); // 12.09.1800

            // test 5
            result = DayOfProgrammer(1801);
            Console.WriteLine(result); // 13.09.1801

            // test 6
            result = DayOfProgrammer(1916);
            Console.WriteLine(result); // 12.09.1916

            // test 7
            result = DayOfProgrammer(1836);
            Console.WriteLine(result); // 12.09.1836

            // test 8
            result = DayOfProgrammer(1918);
            Console.WriteLine(result); // 26.09.1918

            Console.ReadLine();
        }

        static string DayOfProgrammer(int year)
        {
            var timeMachine = new TimeMachine(year);
            return timeMachine.GetDayOfTheProgrammer().ToString("dd.MM.yyyy");
        }
    }
}
