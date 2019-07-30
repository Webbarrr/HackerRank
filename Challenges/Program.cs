using System;
using Challenges.DrawingBook;
using Challenges.SockMerchant;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PageCount(6, 2)); // 1
            Console.WriteLine(PageCount(5, 4)); // 0
            Console.WriteLine(PageCount(4, 4)); // 0
            Console.WriteLine(PageCount(5, 1)); // 0
            Console.WriteLine(PageCount(6, 4)); // 1

            Console.ReadLine();
        }

        static int PageCount(int n, int p)
        {
            var book = new Book(n);
            return book.TurnToPage(p);
        }
    }
}
