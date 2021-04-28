using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Create a C# program that implements an Vehicle interface with two methods, one for Drive of type void and 
//another for Refuel of type bool that has a parameter of type integer with the amount of gasoline to refuel. 
//Then create a Car class with a builder that receives a parameter with the car's starting gasoline amount and 
//implements the Drive and Refuel methods of the car.

//The Drive method will print on the screen that the car is Driving, if the gasoline is greater than 0. 
//The Refuel method will increase the gasoline of the car and return true.

//To carry out the tests, create an object of type Car with 0 of gasoline in the Main of the program and ask 
//the user for an amount of gasoline to refuel, finally execute the Drive method of the car.

namespace day_5
{
  interface IVehicle
  {
        void Drive();
        bool Refuel(int a);
  }
    class Car : IVehicle
    {
        public int fuelamt { get; set; }
        
        public Car (int _fuel)
        {
            fuelamt = _fuel;
        }

        public void Drive()
        {
            
            if (fuelamt == 0)
            {
                Console.WriteLine(" fuel is zero please refill");
            }
            else
            {
                Console.WriteLine("Car is driving");
            }
            
        }
        public bool Refuel(int a)
        {
           

            fuelamt = fuelamt + a;
            Console.WriteLine("fuel remaining" + fuelamt);
            return true;

        }

        bool IVehicle.Refuel(int a)
        {
            throw new NotImplementedException();
        }

        internal bool Refuel(object fuelamt)
        {
            throw new NotImplementedException();
        }
    

         public static void Main()
        {
         Car car = new Car(0);
         Console.WriteLine("Enter the fuel");
         int fuel = Convert.ToInt32(Console.ReadLine());
         if (car.Refuel(car.fuelamt))
         {
            car.Drive();
         }

            Console.ReadLine();
        }
    }
}



