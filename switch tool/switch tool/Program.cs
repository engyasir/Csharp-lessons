using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_tool
{
    class Program
    {
        static void Main(string[] args)
        {
            string  engineer = "Yasser";

            switch (engineer)
            {
                case "Yasser":
                    Console.WriteLine("Engineer Yasser");
                    break;
                case "bye":
                    Console.WriteLine("bye Yasser");
                    break;
                case "welcome":
                    Console.WriteLine("welcom Yasser");
                    break;
                default:
                    Console.WriteLine(" no one");
                    break;
            }
            Console.ReadKey();

            
        }
    }
}
