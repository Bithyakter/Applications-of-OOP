using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceExam
{
    class TwoWheeler : Vehicle, IExterior
    {
        public string FrontBreak { get; set; }
        public string RearBreak { get; set; }
        public void DesignExterior(Motorcycle motorcycle)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Design " + motorcycle.vehicleTypes + " Motorcycle !!\n");
            Console.WriteLine
            (
                motorcycle.ModelNo
                + " Y" + motorcycle.YearMake
                + " Seat" + motorcycle.NumberOfSeat
                + " CC" + motorcycle.EngineCapacityCC
                + " Front Break" + motorcycle.FrontBreak
                + " Rear Break" + motorcycle.RearBreak
            );
        }
    }
}
