using ApplicationCore.Enums;
using ApplicationCore.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    [Table("Cars")]
    public class Car : BaseEntity
    {
        public Car( string model, int makeId, int doorQty, ETransmissionType transmissionType, int year, EFuelType fuelType)
        {
            
            Model = model;
            MakeId = makeId;
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
        public int DoorQty { get; private set; }
        public ETransmissionType TransmissionType { get; private set; }
        public int Year { get; private set; }
        public EFuelType FuelType { get; private set; }

        public void UpdateData(string model, int makeId, int doorQty, ETransmissionType transmissionType, int year, EFuelType fuelType)
        {

            Model = model;
            MakeId = makeId;
            DoorQty = doorQty;
            TransmissionType = transmissionType;
            Year = year;
            FuelType = fuelType;
        }
    }
}
