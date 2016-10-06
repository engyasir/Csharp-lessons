using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   double mysalary = 1090000, total = 0.0;
               int i = 0;

               do
               {
                   total += mysalary;
                   i++;
                    Console.WriteLine("i value equal {0}", i);
               }
               while
               (i < 12);
                    Console.WriteLine("the total is= {0} ", total);
                    Console.ReadKey();
                    */

            double mysalary = 1020;
            int i = 0, month;

            do
            {
                mysalary += 20;
                i++;
                Console.WriteLine("the value is i {0}", i);
            }
            while
            (mysalary < 2000);

                      month = i% 12;
            Console.WriteLine("you need year to reach $2000 :" + i / 12 + "year and " + month + "month");
            Console.ReadKey();
        }
    }
}
