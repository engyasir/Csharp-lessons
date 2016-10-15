using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxvalue
{
    class Program
    {
        static double Avareg_value(double [] myarray1)
        {
            double marks = 0.0, avrage;

            for (int i = 0; i < myarray1.Length; i++)

            {
                marks += myarray1[i];
            }

            avrage = marks / 7;

            return avrage;

                   }
        static void Main(string[] args)
        {
            double[] lessons = { 88, 95, 90, 83, 80, 94, 83 };
            double avarge = Avareg_value(lessons);
            Console.WriteLine($" tha avarge value is ({avarge})");
            Console.ReadKey();

        }
    }
}
