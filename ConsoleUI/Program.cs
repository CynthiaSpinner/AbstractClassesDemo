using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
          #region Vehicles

          Car car1 = new Car();

          Vehicle vehicle = new Car();

          

            

            List<Vehicle> vehicles = new List<Vehicle>();




            //* Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes

            var georgesToyota = new Car()
            {
                Make = "Toyota",
                Model = "Camry",
                Year = "2021"
            };

            var georgesDucati = new Motorcycle()
            {
                Make = "Ducati",
                Model = "Monster",
                Year = "2024"
            };

            Car cynthiasRover = new Car()
            {
                Make = "Land Rover",
                Model = "Range Rover",
                Year = "2024"
            };

            Motorcycle cynthiasCycle = new Motorcycle()
            {
                Make = "Ducati",
                Model = "Street Fighter",
                Year = "2024"
            };

            vehicles.Add(georgesToyota);
            vehicles.Add(georgesDucati);
            vehicles.Add(cynthiasRover);
            vehicles.Add(cynthiasCycle);
                        

            
             /* Using a foreach loop iterate through the list and display each of the properties
             */
            foreach(var item in vehicles) 
            {
                Console.WriteLine($"{item.Year} {item.Make} {item.Model}");

            }

            // Call each of the drive methods for one car and one motorcycle
            cynthiasRover.DriveAbstract();
            cynthiasRover.DriveVirtual();

            georgesDucati.DriveAbstract();
            georgesDucati.DriveVirtual();


            #endregion
            Console.ReadLine();
        }
    }
}
