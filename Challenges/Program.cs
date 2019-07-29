using System;
using Challenges.SockMerchant;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = SockMerchant(7, new int[] {1,2,1,2,1,3,2});
            Console.WriteLine(result); // 2

            result = SockMerchant(9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 });
            Console.WriteLine(result); //3

            Console.ReadLine();
        }

        static int SockMerchant(int n, int[] ar)
        {
            var sockLogic = new SockLogic();
            return sockLogic.CountPairs(ar);
        }

    }
}
