using ApplicationCore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Base
{
    public class Vehicle : BaseEntity
    {
        public EVehicleType VehicleType { get; set; }
    }
}