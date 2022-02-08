using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }

        public bool HasSidecar { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle can drive");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("This vehicle has 2 wheels");
        }
    }
}
