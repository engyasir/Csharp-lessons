using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_example
{
    class Program
    {
        static void Main(string[] args)
        {

            int k = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                    Console.Write((j == (7 - k) || j == (7 + k)) ? (char)(65 + k) : ' ');

                k += i < 7 ? 1 : -1;
                Console.WriteLine();
            }
                    Console.ReadLine();
        }

            
             
     }
    
}
