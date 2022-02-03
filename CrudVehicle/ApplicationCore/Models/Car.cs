using ApplicationCore.Enums;
using ApplicationCore.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Models
{
    [Table("Cars")]
    public class Car : BaseEntity
    {
        public Car( string model, int makeId, string makeName, int doorQty, ETransmissionType transmissionType, int year, EFuelType fuelType)
        {
            
            Model = model;
            MakeId = makeId;
            MakeName = makeName;
            DoorQty = doorQty;
            TransmissionType = transmissionType;
            Year = year;
            FuelType = fuelType;
        }

        [Required]
        [MaxLength(24)]
        [Column("Name", TypeName = "NVARCHAR")]
        public string Model { get; private set; }
        [ForeignKey("MakeId")] 
        public int MakeId { get; private set; }
        [ForeignKey("Name")]
        public string MakeName { get; private set; }
        public int DoorQty { get; private set; }
        public ETransmissionType TransmissionType { get; private set; }
        public int Year { get; private set; }
        public EFuelType FuelType { get; private set; }

        public void UpdateData(string model, int makeId, string makeName, int doorQty, ETransmissionType transmissionType, int year, EFuelType fuelType)
        {

            Model = model;
            MakeId = makeId;
            MakeName = makeName;
            DoorQty = doorQty;
            TransmissionType = transmissionType;
            Year = year;
            FuelType = fuelType;
        }
    }
}
