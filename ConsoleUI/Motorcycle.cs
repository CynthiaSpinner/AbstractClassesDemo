using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public string HasSideCart { get; set; } = "no";

        public override void DriveAbstract()
        {
            Console.WriteLine($"I'm loving my {GetType().Name} written in motorcycle");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("love this motorcycle!");
        }
    }
}
