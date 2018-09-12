using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleAndOrange
{
    class Program
    {
        static void Main()
        {
            string[] house = Console.ReadLine().Split(' ');
            int leftside = Convert.ToInt32(house[0]);
            int rightside = Convert.ToInt32(house[1]);
            string[] trees = Console.ReadLine().Split(' ');
            int appleTree = Convert.ToInt32(trees[0]);
            int orangeTree = Convert.ToInt32(trees[1]);
            string[] amount_of_fruits = Console.ReadLine().Split(' ');
            int appleAmount = Convert.ToInt32(amount_of_fruits[0]);
            int orangeAmount = Convert.ToInt32(amount_of_fruits[1]);
            string[] InputAppleDistance = Console.ReadLine().Split(' ');
            int[] appleDistance = new int[appleAmount];
            for (int i = 0; i < appleAmount; i++)
            {
                appleDistance[i] = Convert.ToInt32(InputAppleDistance[i]);
            }
            string[] InputOrangeDistance = Console.ReadLine().Split(' ');
            int[] orangeDistance = new int[orangeAmount];
            for (int i = 0; i < orangeAmount; i++)
            {
                orangeDistance[i] = Convert.ToInt32(InputOrangeDistance[i]);
            }
            int apple_on_house = 0;
            int orange_on_house = 0;
            for(int i = 0; i < appleAmount; i++)
            {
                if (appleDistance[i] + appleTree >= leftside && appleDistance[i] + appleTree <= rightside)
                {
                    apple_on_house++;
                }
            }
            for (int i = 0; i < orangeAmount; i++)
            {
                if (orangeDistance[i] + orangeTree >= leftside && orangeDistance[i] + orangeTree <= rightside)
                {
                    orange_on_house++;
                }
            }
            Console.WriteLine(apple_on_house);
            Console.WriteLine(orange_on_house);
            Console.ReadKey();
        }
    }
}
