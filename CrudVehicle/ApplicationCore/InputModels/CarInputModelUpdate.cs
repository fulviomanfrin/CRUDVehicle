using ApplicationCore.Enums;

namespace ApplicationCore.InputModels
{
    public class CarInputModelUpdate
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int MakeId { get; set; }
        public int DoorQty { get; set; }
        public ETransmissionType TransmissionType { get; set; }
        public int Year { get; set; }
        public EFuelType FuelType { get; set; }

        public CarInputModelUpdate(int id, string model, int makeId, int doorQty, ETransmissionType transmissionType, int year, EFuelType fuelType)
        {
            Id = id;
            Model = model;
            MakeId = makeId;
            DoorQty = doorQty;
            TransmissionType = transmissionType;
            Year = year;
            FuelType = fuelType;
        }
    }
}
