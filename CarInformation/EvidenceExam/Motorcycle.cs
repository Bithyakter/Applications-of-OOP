using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceExam
{
    sealed class Motorcycle : TwoWheeler
    {
        public Motorcycle()
        {
            vehicleTypes = VehicleType.TwoWheeler;
            NumberOfSeat = 2;
        }
        public int BHP { get; set; }
    }

}
