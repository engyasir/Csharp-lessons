using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int [][] array = new int [2][];

            //    array[0] = new int[5] { 4, 6, 9, 7, 5 };
            //    array[1] = new int[4] { 8, 3, 5, 2 };

            //    for (int i = 0; i < array.Length; i++) 
            //    {
            //        Console.Write("elemnt({0})" ,i);
            //        for (int j = 0; j < array[i].Length; j++)
            //        {
            //            Console.Write("{0}",array[i][j]+ " ");
            //        }
            //        Console.WriteLine(" ");
            //    }
            //    Console.ReadKey();


            int[][] array = new int[3][];

            array[0] = new int[5] { 4, 6, 9, 7, 5 };
            array[1] = new int[4] { 8, 3, 5, 2 };
            array[2] = new int[3] { 6, 1, 3 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" elemnt({0})", i);
                for (int j = 0; j < array[i].Length; j++)

                {
                    Console.Write(" {0}", array[i][j] + " ");
                    
                }
                   Console.WriteLine(" ");
                    
                   Console.WriteLine(" ");
                }
                
                   Console.ReadKey();


        }

    }
}
