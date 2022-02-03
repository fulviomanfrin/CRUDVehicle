using ApplicationCore.Enums;

namespace ApplicationCore.InputModels
{
    public class CarInputModel
    {
        public int? Id { get; set; }
        public string Model { get; set; }
        public int MakeId { get; set; }
        public string MakeName { get; set; }
        public int DoorQty { get; set; }
        public ETransmissionType TransmissionType { get; set; }
        public int Year { get; set; }
        public EFuelType FuelType { get; set; }



    }
}
