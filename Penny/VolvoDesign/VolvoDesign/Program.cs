﻿using System;

namespace VolvoDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            if (car.DriveToFast())
            {
                Console.WriteLine("Your car lost a wheel and exploded!!!");
            }
            
        }
    }
}


//Volvo design bureau or fun with inheritance. 

//Create a blueprint for a different a 3 different type of cars(crossover, sedan, truck).

//Provide as much details and common actions in a base classes as possible.
//Each car have engine, with a serial number, car have vin number, consider adding 6 more components and make sure that if blueprint is created, it cannot be changed later on.

//Build at least 3 blueprints(and as many classes as you want) and make sure that there are no code duplications among them.
