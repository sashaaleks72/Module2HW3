using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class MotorcycleService : IMovable
    {
        public Motorcycle Motorcycle { get; set; }

        public void Run()
        {
            Motorcycle.CurrentSpeed = new Random().Next(Convert.ToInt32(Motorcycle.MaxSpeed));
            Motorcycle.State = "Moving";
            Console.WriteLine($"Motorcycle is driving about {Motorcycle.CurrentSpeed} km/h");
        }

        public void Stop()
        {
            Motorcycle.State = "Staying";
            Console.WriteLine("Motorcycle has been stopped");
        }
    }
}
