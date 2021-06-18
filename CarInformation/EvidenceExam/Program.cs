using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle v = new Vehicle(); // you can't intiated this Vehicle class becasue it is a abstract class
            // in this case you will get a compile time error

            Console.WriteLine("choose vehicle:");
            Console.WriteLine("Input '4' for Car or Input '2' for Motorcycle");
            int vehicleType = int.Parse(Console.ReadLine());
            if (vehicleType == (int)VehicleType.FourWheeler)
            {
                Car objCar = new Car();
                Console.WriteLine("Input CC:");
                objCar.EngineCapacityCC = int.Parse(Console.ReadLine());

                Console.WriteLine("Input Model Number:");
                objCar.ModelNo = Console.ReadLine();

                Console.WriteLine("Input Year:");
                objCar.YearMake = int.Parse(Console.ReadLine());

                Console.WriteLine("Input Number Of Gear:");
                objCar.NumberOfGear = int.Parse(Console.ReadLine());

                Console.WriteLine("Input Number Of Door:");
                objCar.NumberOfDoor = int.Parse(Console.ReadLine());

                IInterior iinterior = new FourWheeler();
                iinterior.DesignInterior(objCar);
            }

            else if (vehicleType == (int)VehicleType.TwoWheeler)
            {
                Motorcycle oMotorcycle = new Motorcycle();
                Console.WriteLine("input CC:");
                oMotorcycle.EngineCapacityCC = int.Parse(Console.ReadLine());
                Console.WriteLine("input Milage:");
                oMotorcycle.MilagePowerNM = decimal.Parse(Console.ReadLine());
                Console.WriteLine("input Model Number:");
                oMotorcycle.ModelNo = Console.ReadLine();
                Console.WriteLine("input Front Break:");
                oMotorcycle.FrontBreak = Console.ReadLine();
                Console.WriteLine("input Rear Break:");
                oMotorcycle.RearBreak = Console.ReadLine();
                Console.WriteLine("input Year:");
                oMotorcycle.YearMake = int.Parse(Console.ReadLine());

                IExterior iExterior = new TwoWheeler();
                iExterior.DesignExterior(oMotorcycle);
            }
            else
            {
                Console.WriteLine("vehicle not found.");
            }

            Console.ReadLine();
        }
    }
}
