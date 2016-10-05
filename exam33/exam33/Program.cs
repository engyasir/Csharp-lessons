using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam33
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int myvar1 = 11, myvar2 = 5, myvar3 = 8;

              bool result1;
              bool result2;

              result1 = (myvar1 <= 11) || (myvar2 == 5) && (myvar3 >= 8);
              result2= (myvar1 <= 11) || (myvar2 == 6) && (myvar3 >= 8);
              Console.WriteLine(" the total1 is {0} \n the total2 is {1}", result1,result2);
              Console.ReadKey();
              */
            int myvar1 = 11, myvar2 = 5, myvar3 = 8;

            if ((myvar1 <= 11) || (myvar2 == 5) && (myvar3 >= 8))
            {
                Console.WriteLine("the result is true ");

            }
            
                else
            { 
                Console.WriteLine("the result is fuls");
            }
            if ((myvar1 <= 11) || (myvar2 == 6) && (myvar3 >= 8))

            {
                Console.WriteLine("the result is true");
            }
            else
            {
                Console.WriteLine("the result is fuls");

            }
            Console.ReadKey();
        }
    }
}
