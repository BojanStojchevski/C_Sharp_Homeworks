using Homework4.Task2.Model;
using System;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Home5
{
    internal class Program
    {

//         - Make a class Driver. Add properties: Name, Level
//         - Make a class Car. Add properties: Model, Speed and Driver
//         - Make a method of the Car class called : CalculateSpeed() that takes a driver object and calculates the skill multiplied by the speed of the car and return it as a result.
//         - Make a method RaceCars() that will get two Car objects that will determine which car will win and print the result in the console.
//         - Make 4 car objects and 4 driver objects.
//         - Ask the user to select a two cars and two drivers for the cars. Add the drivers to the cars and call the RaceCars() methods

        static void Main(string[] args)
        {
                Car car1 = new Car();
                    car1.Model = "Bmw";
                    car1.Speed = 150;
                    car1.Driver = new Driver { Name = "Bojan", Level = 4 };
                    int skill = car1.CalculateSpeed(car1.Driver);

                Car car2 = new Car();
                    car2.Model = "Mercedes";
                    car2.Speed = 180;
                    car2.Driver = new Driver { Name = "Dragan", Level = 5 };

                    RaceCars(car1, car2);

                
            //Make 4 car objects
                Car car11 = new Car { Model = "Hyundai", Speed = 150 };
                Car car22 = new Car { Model = "Mazda", Speed = 170 };
                Car car33 = new Car { Model = "Ferrari", Speed = 280 };
                Car car44 = new Car { Model = "Porsche", Speed = 250 };
                
            //Make 4 driver objects.
                Driver driver1 = new Driver { Name = "Bojan", Level = 3 };
                Driver driver2 = new Driver { Name = "Zoran", Level = 4 };
                Driver driver3 = new Driver { Name = "Goran", Level = 2 };
                Driver driver4 = new Driver { Name = "Stojan", Level = 1 };


                //Ask the user to select a two cars and two drivers for the cars.
                //Add the drivers to the cars and call the RaceCars() methods
                
            Car firstCar = new Car(); //prazna kola 1
            Car secondCar = new Car();//prazna kola 2

            Driver firstDriver = new Driver();
            Driver secondDriver = new Driver();

                while (true)
                {
                try
                {


                    Console.WriteLine("Choose a car no.1:");
                    Console.WriteLine("1-Hyundai");
                    Console.WriteLine("2-Mazda");
                    Console.WriteLine("3-Ferrari");
                    Console.WriteLine("4-Porsche");
                    
                    int chosenFirstCar = int.Parse(Console.ReadLine());
                    if (chosenFirstCar == 1)
                    {
                        firstCar = car11;
                    }
                    else if (chosenFirstCar == 2)
                    {
                        firstCar = car22;
                    }
                    else if (chosenFirstCar == 3)
                    {
                        firstCar = car33;
                    }
                    else if (chosenFirstCar == 4)
                    {
                        firstCar = car44;
                    }
                    else
                    {
                        Console.WriteLine("Izbravte nepostoecka kola");
                    }

                    Console.WriteLine("Choose Driver 1:");
                    Console.WriteLine("1-Bojan");
                    Console.WriteLine("2-Zoran");
                    Console.WriteLine("3-Goran");
                    Console.WriteLine("4-Stojan");
                    int izbrannSoferPrv = int.Parse(Console.ReadLine());
                    if (izbrannSoferPrv == 1)
                    {
                        firstDriver = driver1;
                    }
                    else if (izbrannSoferPrv == 2)
                    {
                        firstDriver = driver2;
                    }
                    else if (izbrannSoferPrv == 3)
                    {
                        firstDriver = driver3;
                    }
                    else if (izbrannSoferPrv == 4)
                    {
                        firstDriver = driver4;
                    }
                    else
                    {
                        Console.WriteLine("Izbravte nepostoecki driver");
                    }

                    Console.WriteLine("Choose a car no.2:");
                    Console.WriteLine("1-Hyundai");
                    Console.WriteLine("2-Mazda");
                    Console.WriteLine("3-Ferrari");
                    Console.WriteLine("4-Porsche");
                    int izbranaKolaVtora = int.Parse(Console.ReadLine());

                    if (izbranaKolaVtora == 1)
                    {
                        secondCar = car11;
                    }
                    else if (izbranaKolaVtora == 2)
                    {
                        secondCar = car22;
                    }
                    else if (izbranaKolaVtora == 3)
                    {
                        secondCar = car33;
                    }
                    else if (izbranaKolaVtora == 4)
                    {
                        secondCar = car44;
                    }
                    else
                    {
                        Console.WriteLine("Izbravte nepostoecka kola");
                    }

                    Console.WriteLine("Choose Driver 2:");
                    Console.WriteLine("1-Bojan");
                    Console.WriteLine("2-Zoran");
                    Console.WriteLine("3-Goran");
                    Console.WriteLine("4-Stojan");
                    int izbrannSoferVtor = int.Parse(Console.ReadLine());
                    if (izbrannSoferVtor == 1)
                    {
                        secondDriver = driver1;
                    }
                    else if (izbrannSoferVtor == 2)
                    {
                        secondDriver = driver2;
                    }
                    else if (izbrannSoferVtor == 3)
                    {
                        secondDriver = driver3;
                    }
                    else if (izbrannSoferVtor == 4)
                    {
                        secondDriver = driver4;
                    }
                    else
                    {
                        Console.WriteLine("Izbravte nepostoecki driver");
                    }

                    //Add Driver in Car
                    firstCar.Driver = firstDriver;
                    secondCar.Driver = secondDriver;

                    if (firstDriver == secondDriver)
                    {
                        Console.WriteLine("DriverPri treba da e razlicen od DriverVtior");
                    }
                    else if (firstCar == secondCar)
                    {
                        Console.WriteLine("Kola prva ne moze da bide enakva so koa vtora");
                    }
                    else
                    {
                        RaceCars(firstCar, secondCar);
                    }   


                }catch (Exception ex) 
                {
                    Console.WriteLine("Error: " +ex.Message);
                }

                    Console.ReadLine();
                
            }
            

            
        }

        public static void RaceCars(Car car1, Car car2)
        {
            int speedCar1 = car1.CalculateSpeed(car1.Driver);
            int speedCar2 = car2.CalculateSpeed(car2.Driver);

            if (speedCar1 > speedCar2)
            {
                Console.WriteLine("Winner is: Car Model: " + car1.Model + " Driver Name: " + car1.Driver.Name + " Speed: " + car1.Speed);
                Console.WriteLine(car1.Model + " e pobrz od " + car2.Model);
            }
            else if (speedCar1 < speedCar2)
            {
                Console.WriteLine("Winner is: Car Model: " + car2.Model + " Driver Name: " + car2.Driver.Name + " Speed: " + car2.Speed);
                Console.WriteLine(car2.Model + " e pobrz od " + car1.Model);
            }
            else
            {
                Console.WriteLine("No Winner");
            }
        }
    }
}