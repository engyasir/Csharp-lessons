using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exmp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float flval = 1f / 3;
            double dval = 1d / 3;
            decimal mval = 1m / 3;
            Console.WriteLine(" float value = {0}\n double value = {1}\n decimal value = {2}\n ", flval, dval, mval);
            Console.ReadKey();

        }
    }
}
