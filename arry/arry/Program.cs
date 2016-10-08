using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arry
{
    class Program
    {
        static void Main(string[] args)
        {
            const int myArrysize = 6;
            int[] mynumbers = new int[myArrysize] { 2, 5, 7, 8, 4 ,3 };

            for (int i = 0; i < 6; i++)

            Console.WriteLine("my number " + (i + 0) + " = " + $" {mynumbers[i]} " + " ");
            Console.ReadKey();

            
        }
    }
}
