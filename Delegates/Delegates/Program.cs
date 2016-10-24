using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class string_minjob

    {
        public static string textCase(string text)
    {
            if (text == text.ToUpper())

            {
                return "your textstring is Upper";
            }
            else if (text == text.ToLower())
            {
                return "your textstring is small";
            }
            else
            {
                return "your text is Maxture";
            }
        }

    public string textlength(string text)

       {
        return ($" your textsteing lingth is { text.Length}");

       }


       }



    class Program
    {
        public delegate string mydelegate(string text);

        static void Main(string[] args)
        {
            string_minjob st = new string_minjob();
            mydelegate firstJob = string_minjob.textCase;
            mydelegate secndjob = new mydelegate(st.textlength);

            Console.WriteLine(" enter your textstring\n");
           string text= Console.ReadLine();
            Console.WriteLine(firstJob(text));
            Console.WriteLine(secndjob(text));

            Console.ReadKey();

        }
    }
}
