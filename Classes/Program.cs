using System.Collections.Generic;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Car class
            Car myCar = new Car();

            // Set values in the properties for the object
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2022;

            // Print the values of each property to the Console
            Console.WriteLine("Car Make: " + myCar.Make);
            Console.WriteLine("Car Model: " + myCar.Model);
            Console.WriteLine("Car Year: " + myCar.Year);
        }
    }
}



//## Exercise 1:

//+Create a class named Car - make sure it is public

//### In the Car class:
//+Create a Make property of type string that is public
//   +Create a Model property of type string that is public
// +Create a Year property of type int that is public
//   +Create a new instance of the Car class
//   + Print the values of each property to the Console