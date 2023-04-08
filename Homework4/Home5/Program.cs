using Home5.Model;
using System;
using System.Runtime.ConstrainedExecution;

namespace Home5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
                //Prviot Del od Zadacata
                Car car1 = new Car();
                car1.Model = "Bmw";
                car1.Speed = 150;
                car1.Driver = new Driver { Name = "Bojan", Level = 2 };
                int speed = car1.CalculateSpeed(car1.Driver);

                Car car2 = new Car();
                car2.Model = "Mercedes";
                car2.Speed = 180;
                car2.Driver = new Driver { Name = "Dragan", Level = 3 };

                RaceCars(car1, car2);

                //Make a method RaceCars() that will get two Car objects
                //that will determine which car will win and print
                //the result in the console.
                //RaceCars(car1, car2);


                //OVOJ DEL E OD 5TA TOCKA OD ZADACATA PA NADOLE
                //Make 4 car objects
                Car car11 = new Car { Model = "Hyundai", Speed = 180 };
                Car car22 = new Car { Model = "Mazda", Speed = 200 };
                Car car33 = new Car { Model = "Ferrari", Speed = 160 };
                Car car44 = new Car { Model = "Porsche", Speed = 150 };
                //Make 4 driver objects.
                Driver driver1 = new Driver { Name = "Bojan", Level = 3 };
                Driver driver2 = new Driver { Name = "Zoran", Level = 4 };
                Driver driver3 = new Driver { Name = "Goran", Level = 2 };
                Driver driver4 = new Driver { Name = "Stojan", Level = 1 };


                //Ask the user to select a two cars and two drivers for the cars.
                //Add the drivers to the cars and call the RaceCars() methods
                Car kolaPrva = new Car(); //prazna kola 1
                Car kolaVtora = new Car();//prazna kola 2

                Driver driverPrv = new Driver();
                Driver driverVtor = new Driver();

                while (true)
                {
                try
                {


                    Console.WriteLine("Choose a car no.1:");
                    Console.WriteLine("1-Hyundai");
                    Console.WriteLine("2-Mazda");
                    Console.WriteLine("3-Ferrari");
                    Console.WriteLine("4-Porsche");
                    int izbranaKolaPrva = int.Parse(Console.ReadLine());
                    if (izbranaKolaPrva == 1)
                    {
                        kolaPrva = car11;
                    }
                    else if (izbranaKolaPrva == 2)
                    {
                        kolaPrva = car22;
                    }
                    else if (izbranaKolaPrva == 3)
                    {
                        kolaPrva = car33;
                    }
                    else if (izbranaKolaPrva == 4)
                    {
                        kolaPrva = car44;
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
                        driverPrv = driver1;
                    }
                    else if (izbrannSoferPrv == 2)
                    {
                        driverPrv = driver2;
                    }
                    else if (izbrannSoferPrv == 3)
                    {
                        driverPrv = driver3;
                    }
                    else if (izbrannSoferPrv == 4)
                    {
                        driverPrv = driver4;
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
                        kolaVtora = car11;
                    }
                    else if (izbranaKolaVtora == 2)
                    {
                        kolaVtora = car22;
                    }
                    else if (izbranaKolaVtora == 3)
                    {
                        kolaVtora = car33;
                    }
                    else if (izbranaKolaVtora == 4)
                    {
                        kolaVtora = car44;
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
                        driverVtor = driver1;
                    }
                    else if (izbrannSoferVtor == 2)
                    {
                        driverVtor = driver2;
                    }
                    else if (izbrannSoferVtor == 3)
                    {
                        driverVtor = driver3;
                    }
                    else if (izbrannSoferVtor == 4)
                    {
                        driverVtor = driver4;
                    }
                    else
                    {
                        Console.WriteLine("Izbravte nepostoecki driver");
                    }

                    //Add Driver in Car
                    kolaPrva.Driver = driverPrv;
                    kolaVtora.Driver = driverVtor;

                    if (driverPrv == driverVtor)
                    {
                        Console.WriteLine("DriverPri treba da e razlicen od DriverVtior");
                    }
                    else if (kolaPrva == kolaVtora)
                    {
                        Console.WriteLine("Kola prva ne moze da bide enakva so koa vtora");
                    }
                    else
                    {
                        RaceCars(kolaPrva, kolaVtora);
                    }


                }catch (Exception ex) 
                {
                    Console.WriteLine("greska " +ex.Message);
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