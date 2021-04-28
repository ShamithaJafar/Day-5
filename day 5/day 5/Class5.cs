using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Create a C# program that prompts the user for three names of people and
//    stores them in an array of Person-type objects. To do this, 
//    first create a Person class that has a Name property of type string, 
//    a constructor that receives the name as a parameter, a destructor that 
//    assigns the name to empty and overwrites the ToString () method.

//End the program by reading the people and executing the ToString () method
//    on screen.

namespace day_5
{
    class Class5

    {
        public static void Main()
        {
            Console.WriteLine("enter the number of names that need to be given: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Person[] array = new Person[n];
            Console.WriteLine("enter the names: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = new Person(Console.ReadLine());
                
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(array[i].ToString());


            }

        }

     
    }
    public class Person
    {
        public string Name { get; set; }

        public Person(string Personname)
        {
            Name = Personname;
        }
        public override string ToString()
        {
            return ("Name is " + Name);
        }
        ~ Person()
        {
            Name = string.Empty;
        }
    }

}
