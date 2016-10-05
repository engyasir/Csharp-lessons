using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternaray_condition
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvar = 10;
            string result = (myvar < 11) ? "less than 11" : "greater than 11";
            Console.WriteLine(" the total is {0}", result);
            Console.ReadKey();

        }
    }
}
