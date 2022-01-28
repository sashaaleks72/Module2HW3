using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class Motorcycle : Bicycle
    {
        public Motorcycle(double weight, double maxSpeed, double sizeOfWheels)
            : base(weight, maxSpeed, sizeOfWheels)
        {
        }

        public override string ToString()
        {
            return $"Max speed: {MaxSpeed} km/h\nWeight: {Weight} kg\nSize of wheels: {SizeOfWheels} inches\nState: {State}";
        }
    }
}
