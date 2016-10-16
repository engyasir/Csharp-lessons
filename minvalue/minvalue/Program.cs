using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minvalue
{
    class Program
    {

        public static int MinValue(int[] myarray2)
        {
            int minval = myarray2[0];
             
            for (int i = 0; i < myarray2.Length; i++)
            {
                if (myarray2[i] < minval)
                
              minval = myarray2[i];
              
            }
            return minval;

            }
            public  static double MinValue(double  minval)
            {
                      
             return minval;
            }
        static void Main(string[] args)
        {

            int[] myarray1 = { 9, 40, 10, 13, 3, 11, 8, 20, 6, 35 };
            double minval = MinValue(myarray1);

                      
            Console.Write($" the minmum value is : {MinValue(minval)}");
            Console.ReadKey();
        
        }
    }
}
