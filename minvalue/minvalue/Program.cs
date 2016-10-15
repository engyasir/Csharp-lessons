using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minvalue
{
    class Program
    {
        public static double Min_Value(double[] myarry1, double minval)


        {
            return minval;
        }
        
            public  static int Min_Value(int [] myarray1, int minval)
        {
           // int minval = myarray1[0];
           // double minval = myarray1[0];
            for (int i = 1; i <myarray1.Length; i++)
            {
                if (myarray1[i] < minval)

                    minval = myarray1[i];
            }     
            return minval;
            
        }
        static void Main(string[] args)
        {
            int[] myarray2 = { 9, 40, 5, 13, 2, 11, 8 , 20 , 6 , 35};

           // Console.Write($"{Min_value(minval)}");
            Console.ReadKey();
        }
    }
}
