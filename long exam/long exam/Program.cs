using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace long_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            string myfname, mylname;
            double mysalary, TaxRate , total = 0.0, taxratA=0.0, taxratB = 0.0;
            
            Console.WriteLine("enter first name :");
            myfname = Console.ReadLine();
            Console.WriteLine("enter last name :");
            mylname= Console.ReadLine();
            Console.WriteLine(" enter your salary: ");
            mysalary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter your TaxRate: ");
            TaxRate = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < 12; i++)
            {
                taxratA = TaxRate * mysalary;
                total += mysalary - taxratA;
                taxratB += taxratA;
            }
            Console.WriteLine($" your first name is\n {myfname}");
            Console.WriteLine($" your last name is\n {mylname}");
            Console.WriteLine($" your total salary for 12 month is\n {total} $");
            Console.WriteLine($" your Taxrate for 12 month is\n {taxratB} $");
            Console.WriteLine("\n GOOD BYE");
            Console.ReadKey();


        }
    }
}
