using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken1 = 14;
            int chicken2 = 17;
            int chicken3 = 13;
            int chicken4 = 19;
            int sum = chicken1 + chicken2 + chicken3 + chicken4;
            int dozens = sum / 12;
            int remainder = sum % 12;
            Console.WriteLine("{0} eggs is {1} dozen and {2} eggs", sum, dozens, remainder);
        }
    }
}
