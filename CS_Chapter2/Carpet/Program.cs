using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 25;
            int width = 15;
            int floorSpace = length * width;
            double cost = floorSpace * 5.25;
            Console.Write("The cost of carpeting the room is $");
            Console.WriteLine(cost); 
        }
    }
}
