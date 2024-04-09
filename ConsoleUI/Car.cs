using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public string HasTrunk { get; set; } = "yes";
        public override void DriveAbstract()
        {
            Console.WriteLine($"I'm loving my new {GetType().BaseType.Name} Written in car");
        }
    }
}
