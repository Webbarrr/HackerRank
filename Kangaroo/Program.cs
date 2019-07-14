using System;

namespace Kangaroo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kangaroo(0,3,4,2));
            Console.WriteLine(Kangaroo(0, 2, 5, 3));

            Console.ReadLine();
        }

        static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            var kangaroo1 = new Kangaroo(x1, v1);
            var kangaroo2 = new Kangaroo(x2, v2);

            if (kangaroo1.JumpDistance > kangaroo2.JumpDistance)
                return (kangaroo1.StartingPosition - kangaroo2.StartingPosition) %
                                (kangaroo2.JumpDistance - kangaroo1.JumpDistance) == 0 ? "YES" : "NO";

            return "NO";
        }
    }
}
