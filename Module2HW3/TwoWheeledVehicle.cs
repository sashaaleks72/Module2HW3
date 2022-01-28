using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public abstract class TwoWheeledVehicle : Vehicle
    {
        private double _sizeOfWheels;

        public TwoWheeledVehicle(double weight, double maxSpeed, double sizeOfWheels)
            : base(weight, maxSpeed)
        {
            _sizeOfWheels = sizeOfWheels;
        }

        public double SizeOfWheels => _sizeOfWheels;
    }
}
