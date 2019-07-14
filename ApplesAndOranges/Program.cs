using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace ApplesAndOranges
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CountApplesAndOranges(7, 11, 5, 15, new int[] { -2, 2, 1 }, new[] { 5, -6 });
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        static void CountApplesAndOranges(int houseStartPoint, int houseEndPoint, int appleTreeLocation,
            int orangeTreeLocation, int[] apples, int[] oranges)
        {
            if (apples == null)
                throw new ArgumentNullException(nameof(apples));

            if (oranges == null)
                throw new ArgumentNullException(nameof(oranges));

            var house = new House(houseStartPoint, houseEndPoint);

            var apple = new Apple(appleTreeLocation)
            {
                FallenPositions = apples
            };
            house.CountFallenFruit(apple);

            var orange = new Orange(orangeTreeLocation)
            {
                FallenPositions = oranges
            };
            house.CountFallenFruit(orange);

            Console.ReadLine();
        }
    }
}
