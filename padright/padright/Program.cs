using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace padright
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystr1, mystr2;

            Console.WriteLine("enter the string :");
            mystr1 = Console.ReadLine();

            mystr2 = mystr1.PadRight(14,'e');
            mystr2 = mystr2.PadRight(15,'s');
            mystr2 = mystr2.PadRight(16,'t');
            Console.WriteLine($"{mystr2}");
            Console.ReadKey();
        }
    }
}
