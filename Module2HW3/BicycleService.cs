using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class BicycleService : IMovable
    {
        public Bicycle Bicycle { get; set; }

        public void Run()
        {
            Bicycle.CurrentSpeed = new Random().Next(Convert.ToInt32(Bicycle.MaxSpeed));
            Bicycle.State = "Moving";
            Console.WriteLine($"Bicycle is driving about {Bicycle.CurrentSpeed} km/h");
        }

        public void Stop()
        {
            Bicycle.State = "Staying";
            Console.WriteLine("Bicycle has been stopped");
        }
    }
}
