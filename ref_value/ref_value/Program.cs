using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_value
{
    class Program
    {
        static void multi_num(ref int myvar , ref int myvar1)
            {
            myvar *= 5; myvar1 *= 5;
            Console.WriteLine($" myvar multipli 5 = {myvar}");
            Console.WriteLine($" myvar1 multipli 5 = {myvar1}\n");

        }
        static void Main(string[] args)
        {
            int var = 6, var1 = 4;

            Console.WriteLine($" the number is : {var}");
            Console.WriteLine($" the number is : {var1}\n");
            multi_num(ref var, ref var1);
            Console.WriteLine($" the ref number is : {var}");
            Console.WriteLine($" the ref number  is : {var1}");
            Console.ReadKey();

        }
    }
}
