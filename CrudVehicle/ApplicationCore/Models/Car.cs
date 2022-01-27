using ApplicationCore.Enums;
using ApplicationCore.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class Car : Vehicle
    {
        public string Model { get; private set; }
        public int MakeId { get; private set; }
        public EDoorQty DoorQty { get; private set; }
        public ETransmissionType TransmissionType { get; private set; }
        public int Year { get; private set; }
        public EFuelType FuelType { get; private set; }

    }
}
