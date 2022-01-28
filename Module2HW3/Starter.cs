using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    internal class Starter
    {
        public void Run()
        {
            IMovable bicycleService = new BicycleService();
            IMovable motorcycleService = new MotorcycleService();

            Vehicle bicycle = new Bicycle(12, 60, 27.5, Bicycle.SizeOfFrame.M);
            Vehicle motorcycle = new Motorcycle(150, 200, 4.5);

            ((BicycleService)bicycleService).Bicycle = (Bicycle)bicycle;
            bicycleService.Run();
            bicycleService.Stop();

            ((MotorcycleService)motorcycleService).Motorcycle = (Motorcycle)motorcycle;
            motorcycleService.Run();
            Console.WriteLine();

            Console.WriteLine(bicycle);
            Console.WriteLine();
            Console.WriteLine(motorcycle);
            Console.WriteLine();

            SearchService searchService = new SearchService(bicycle, motorcycle);
            Vehicle vehicle = searchService.SearchVehicleWithTheHighestSpeed();

            Console.WriteLine("Vehicle with the most highest max speed: ");
            if (vehicle is Motorcycle)
            {
                Console.WriteLine(motorcycle);
            }
            else
            {
                Console.WriteLine(bicycle);
            }
        }
    }
}
