using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_main
{
    class Program
    {
        static int mini_val(int[] myarray1, out int myindex)
        {
            int minval = myarray1[0];
            myindex = 0;
            for (int i = 0; i < myarray1.Length; i++)
                if (myarray1[i] < minval)
                {
                    minval = myarray1[i];
                    myindex = i;
                }
            return minval;
                }
        static void multi_num(ref int myvar, ref int myvar1)
        {
            myvar *= 5; myvar1 *= 5;
            Console.WriteLine($" myvar multipli 5 = {myvar}");
            Console.WriteLine($" myvar1 multipli 5 = {myvar1}\n");
        }
            static void Main(string[] args)
        {
            int var1 = 7, var2 = 8;
            Console.WriteLine($" the number is : {var1}");
            Console.WriteLine($" the number is : {var2}\n");
            multi_num(ref var1, ref var2);
            int myindex;
            int[] myarray2={5,14,4,9,11,2,10,25};
            int minval = mini_val(myarray2, out myindex);
            Console.WriteLine($" the minvalue is: {minval}\n" + $" and myindex is: {myindex}");
            Console.ReadKey();



        }
    }
}
