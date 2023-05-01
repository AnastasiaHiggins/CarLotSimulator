using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO



            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var carLot = new CarLot();

            Car redCar = new Car();
                carLot.CarsInLot.Add(redCar);

            Car blueCar = new Car() 
            { 
                Make = "Mustang", 
                Model = "GT-500", 
                Year = 2021, 
                EngineNoise = "WAAAAA WAAAAA WAAAAA",
                HonkNoise = "Beep Beep!",
                IsDriveable = true,
                IsItCool = true
            };
                carLot.CarsInLot.Add(blueCar);

            Car yellowCar = new Car("Hyundai", "Sonata", 2007, "Chug Chug Chug", "BRRTTTTT", false, false);
                carLot.CarsInLot.Add(yellowCar);

            redCar.Make = "Toyota";
            redCar.Model = "Prius";
            redCar.Year = 2015;
            redCar.EngineNoise = "Muhhhhh";
            redCar.HonkNoise = "Bwaaaaa";
            redCar.IsDriveable = true;
            redCar.IsItCool = false;

            redCar.MakeEngineNoise();
            redCar.MakeHonkNoise();

            blueCar.MakeEngineNoise();
            blueCar.MakeHonkNoise();

            yellowCar.MakeEngineNoise();
            yellowCar.MakeHonkNoise();

            foreach (var Car in carLot.CarsInLot)
            {
                Console.WriteLine(Car.Make);
                Console.WriteLine(Car.Model);
                Console.WriteLine(Car.Year);
                Console.WriteLine("Is this a cool car?");

                if(Car.IsItCool == true)
                {
                    Console.WriteLine("Yes it is!");
                }
                else
                {
                    Console.WriteLine("No, it's lame!");
                }
            }

            //for each car in carlot: print to console make, model, year, do i think it's cool? yes or no

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

        }
    }
}
