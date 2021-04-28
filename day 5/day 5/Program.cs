using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    class Program
    {
        Program()
        {
            Console.WriteLine("Construtor called");
        }
        ~Program()
        {
            Console.WriteLine("destructor called");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main program");
            Program p = new Program();
            Console.ReadLine();
        }
    }
}
