using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class CrudVehicleDataContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }
    }
}
