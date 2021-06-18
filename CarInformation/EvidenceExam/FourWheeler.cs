using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceExam
{
    class FourWheeler : Vehicle, IInterior
    {
        public int NumberOfDoor { get; set; }
        public int NumberOfGear { get; set; }
        public void DesignInterior(Car Car)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Design " + Car.vehicleTypes + " Car !!\n");
            Console.WriteLine
            (
                Car.ModelNo
                + " Y" + Car.YearMake
                + " Seat" + Car.NumberOfSeat
                + " CC" + Car.EngineCapacityCC
                + " GEAR" + Car.NumberOfGear
                + " DOOR" + Car.NumberOfDoor
            );
        }
    }
}
