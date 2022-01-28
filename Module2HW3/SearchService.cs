using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class SearchService
    {
        private Vehicle[] _arrayOfObjects;

        public SearchService(params Vehicle[] vehicles)
        {
            _arrayOfObjects = vehicles;
        }

        public Vehicle SearchVehicleWithTheHighestSpeed()
        {
            double maxSpeed = 0;
            int? indexOfVehicle = null;

            Vehicle vehicleWithTheHighestSpeed;

            for (int i = 0; i < _arrayOfObjects.Length; i++)
            {
                if (_arrayOfObjects[i].MaxSpeed > maxSpeed)
                {
                    maxSpeed = _arrayOfObjects[i].MaxSpeed;
                    indexOfVehicle = i;
                }
            }

            vehicleWithTheHighestSpeed = _arrayOfObjects[indexOfVehicle.Value];
            return _arrayOfObjects[indexOfVehicle.Value];
        }
    }
}
