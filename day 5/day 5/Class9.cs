using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Age
    {
        public static void Main()
        {

            DateTime age = new DateTime(1997, 06, 16);
            DateTime date = DateTime.Now;
            Console.WriteLine("Your age is:");
            Console.WriteLine((date.Year - age.Year) + " years " + (date.Month - age.Month) + " Months " + (date.Day - age.Day) + " days ");
            Console.ReadLine();
        }
    }
}
