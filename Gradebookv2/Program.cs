using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebookv2
{
    class Program
    {
        static void Main(string [] args)

        {
            if (args.Length > 0)
            {
                Console.WriteLine("Hello, {args[0]} you some bitch!");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Well Damnit");
                Console.ReadKey();
            }
        }
    }
}
