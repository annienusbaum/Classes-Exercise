using System;
namespace Classes
{

    public class Car
    {
        // Properties with non-null default values in the constructor
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Constructor
        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
        }
    }


}

