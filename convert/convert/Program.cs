using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert
{
    class Program
    {
        static void Main(string[] args)
        {
            float myfvar = 45.56f;
            string mystringvar, mysubstring;
            mystringvar = Convert.ToString(myfvar);
            mysubstring = mystringvar.Substring(2,3);
            Console.WriteLine($"the string value {mystringvar }");
            Console.WriteLine($"the mysubstring value {mysubstring }");
            Console.ReadKey();

            
        }
    }
}
