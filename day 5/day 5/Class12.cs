using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    class Class12
    {
        public static void Main()
        {
            Console.WriteLine("enter the number of elements needed: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("enter the numbers: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);


            }
            int lrg = 0;
            int j = 0;

            for (int i = 0; i < n; i++)
            {
                if (lrg < array[i])
                {
                    lrg = array[i];
                    j = i;
                }
            }
            
            int lrg2nd = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;  
                    i--;
                }
                else
                {
                    if (lrg2nd < array[i])
                    {
                        lrg2nd = array[i];
                    }
                }
            }

            Console.Write("The Second largest element in the array is :  {0} \n\n", lrg2nd);
            Console.ReadLine();
        }


    }
}
   
