using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    class DaysProps
    {
        static void Main(string[] args)
        {
                      
            DateTime dt = DateTime.Now;

            string millisecond = dt.Millisecond.ToString();
            string second = dt.Second.ToString();
            string minute = dt.Minute.ToString();
            string hour = dt.Hour.ToString();

            string day = dt.Day.ToString();
            string month = dt.Month.ToString();
            string year = dt.Year.ToString();


            Console.WriteLine("--------Current date & time is------------\n ");       /*+ dt.ToString());*/
            Console.WriteLine("Current date & time is: " );

            Console.WriteLine("Time is: " + hour+":"+minute+ ":" + second + ":" + millisecond);
            
            Console.WriteLine("Day is: " + day);
            Console.WriteLine("month is: " + month);
            Console.WriteLine("Year is: " + year);
            


            Console.ReadLine();
        }
    }
}
