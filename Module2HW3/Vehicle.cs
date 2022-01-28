using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public abstract class Vehicle
    {
        private double _currentSpeed;
        private double _weight;
        private double _maxSpeed;

        public Vehicle(double weight, double maxSpeed)
        {
            _weight = weight;
            _maxSpeed = maxSpeed;
        }

        public double Weight => _weight;
        public double MaxSpeed => _maxSpeed;
        public double CurrentSpeed
        {
            get
            {
                return _currentSpeed;
            }
            set
            {
                _currentSpeed = value;
            }
        }

        public string State { get; set; }
    }
}
