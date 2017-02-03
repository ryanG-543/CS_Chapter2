using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 25;
            int width = 42;
            int floorSpace = length * width;
            int yardSpace = floorSpace / 9;
            Console.WriteLine("The floor space is {0} square yards", yardSpace);
        }
    }
}
