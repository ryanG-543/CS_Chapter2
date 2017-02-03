using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EggsInteractive
{
    public class InteractiveAddition
    {
        static void Main(string[] args)
        {
            string firstChicken, secondChicken, thirdChicken, fourthChicken, sum;
            int first, second, third, fourth, eggsum;
            Console.WriteLine("How many eggs has the first chicken laid?");
            firstChicken = Console.ReadLine();
            first = Convert.ToInt32(firstChicken);
            Console.WriteLine("Good. There are {0} eggs. How many eggs has the second chicken laid?", firstChicken);
            secondChicken = Console.ReadLine();
            second = Convert.ToInt32(secondChicken);
            Console.WriteLine("Good. There are {0} eggs. How many eggs has the third chicken laid?", secondChicken);
            thirdChicken = Console.ReadLine();
            third = Convert.ToInt32(thirdChicken);
            Console.WriteLine("Good. There are {0} eggs. How many egg shas the fourth chicken laid?");
            fourthChicken = Console.ReadLine();
            fourth = Convert.ToInt32(fourthChicken);
            eggsum = first + second + third + fourth;
            Console.WriteLine("You have {0} eggs in total", eggsum);
        }
    }
}
