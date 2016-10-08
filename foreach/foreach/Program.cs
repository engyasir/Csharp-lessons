using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
         int[] myarry = new int[15] { 20, 30, 40, 50, 60, 11, 22, 33, 44, 55, 100, 200, 300, 400, 500 };
         int accu = 0;

            foreach (int item in myarry)
            {
                accu++;
                if (accu > 14)
                { 
                break;
                }
                Console.WriteLine($"my number is {item}  ({accu})");
            }
                Console.ReadKey();
        }
    }
}
