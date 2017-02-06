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
            int first, second, third, fourth, eggsum, dozens, eggsremainder;
            Console.WriteLine("How many eggs has the first chicken laid?");
            firstChicken = Console.ReadLine();
            first = Convert.ToInt32(firstChicken);
            Console.WriteLine("Good. There are {0} eggs. How many eggs has the second chicken laid?", firstChicken);
            secondChicken = Console.ReadLine();
            second = Convert.ToInt32(secondChicken);
            Console.WriteLine("Good. There are {0} eggs. How many eggs has the third chicken laid?", secondChicken);
            thirdChicken = Console.ReadLine();
            third = Convert.ToInt32(thirdChicken);
            Console.WriteLine("Good. There are {0} eggs. How many eggs has the fourth chicken laid?", thirdChicken);
            fourthChicken = Console.ReadLine();
            fourth = Convert.ToInt32(fourthChicken);
            eggsum = first + second + third + fourth;
            dozens = eggsum / 12;
            eggsremainder = eggsum % 12;
            Console.WriteLine("There are {0} dozen and {1} eggs. In total, you have {2} eggs.", dozens, eggsremainder, eggsum);
        }
    }
}
