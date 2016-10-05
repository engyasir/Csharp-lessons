using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boollesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvar1 = 9, myvar2 = 11;
            bool com1 = (myvar1 <= 10) && (myvar2 <= 11);
            bool com2 = (myvar1 <= 10) || (myvar2 <= 11);
            Console.WriteLine("resutlt1 is = {0} , result2 is = {1}", com1, com2);
            Console.ReadKey();
        }
    }
}
