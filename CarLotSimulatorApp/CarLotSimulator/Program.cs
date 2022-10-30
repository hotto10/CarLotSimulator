using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var carlot = new CarLot();
            //Create a seperate class file called Car-DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable-DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()-DONE
            //The methods should take one string parameter: the respective noise property-DONE


            //Now that the Car class is created we can instanciate 3 new cars-DONE
            //Set the properties for each of the cars-DONE
            //Call each of the methods for each car-DONE
            
            //object Initializing
            var myCar1 = new Car() 
            { 
                Year = 2007,
                Make = "Ford", 
                Model = "Mustang",
                EngineNoise = "Loud",
                HonkNoise = "Soft", 
                IsDriveable = "yes!!" 
            };
            carlot.Add(myCar1);
            
            //Dot Notation
            Car myCar2 = new Car();
            myCar2.Year = 2012;
            myCar2.Make = "Chevy";
            myCar2.Model = "Corvette";
            myCar2.EngineNoise = "Super Loud";
            myCar2.HonkNoise = "Annoying";
            myCar2.IsDriveable = "yes to the yes!!";
            carlot.Add(myCar2);
           
            //Custom Constuctor
            var myCar3 = new Car(2018, "Pontiac", "Grand Prix", "It sucks", "Makes Lots of Noise", "Are you serious???");
            carlot.Add(myCar3);

            

            myCar1.MakeEngineNoise(myCar1.EngineNoise);
            myCar2.MakeEngineNoise(myCar2.EngineNoise);
            myCar3.MakeEngineNoise(myCar3.EngineNoise);
            myCar1.MakeHornNoise(myCar1.HonkNoise);
            myCar2.MakeHornNoise(myCar2.HonkNoise);
            myCar3.MakeHornNoise(myCar3.HonkNoise);

            carlot.ShowCarList();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

           

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
