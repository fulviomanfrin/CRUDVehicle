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
    public class Car : Vehicle
    {
        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Name", TypeName = "NVARCHAR")]
        public string Model { get; private set; }
        [ForeignKey("MakeId")] public int MakeId { get; set; }
        public Make Make { get; private set; }
        public EDoorQty DoorQty { get; private set; }
        public ETransmissionType TransmissionType { get; private set; }
        public int Year { get; private set; }
        public EFuelType FuelType { get; private set; }

    }
}
