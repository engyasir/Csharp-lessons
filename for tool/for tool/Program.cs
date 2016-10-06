using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_tool
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   for (int i = 0; i <= 5; i++)
               {
                   for (int j = 0; j <= 9; j++)
                   {
                       Console.WriteLine(i + "*" + j + " = " + (i * j));

                   }
                   Console.WriteLine();
               }
                   Console.ReadKey();
                   */
            /*   for (int i = 0; i <= 5; i++)
       {
           for (int j = 0; j <= 9; j++)
           {
               Console.WriteLine(i + "*" + j + " = " + (i * j));

           }
           Console.WriteLine();
       }
           Console.ReadKey();
           */

          /*  for (int i = 1; i <= 6; i+=2)
           {
               for (int j = 0; j <= 9; j++)
               {
                   Console.WriteLine(i + "*" + j + " = " + (i * j));

               }
               Console.WriteLine();
           }
               Console.ReadKey();
               */


            for (int i = 0; i <= 6; i += 2)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine(i + "*" + j + " = " + (i * j));

                }
                Console.WriteLine();
            }
            Console.ReadKey();
            // جدول ضرب الى حد الخمسةواعداد الفردية والزوجية مضروبة 

        }
    }
}
