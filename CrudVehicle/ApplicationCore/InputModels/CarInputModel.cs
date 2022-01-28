using ApplicationCore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.InputModels
{
    public class CarInputModel
    {
        public int? Id { get; set; }
        public string Model { get; set; }
        public int MakeId { get; set; }
        public int DoorQty { get; set; }
        public ETransmissionType TransmissionType { get; set; }
        public int Year { get; set; }
        public EFuelType FuelType { get; set; }



    }
}
