using ApplicationCore.Models;
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
        public CrudVehicleDataContext(DbContextOptions<CrudVehicleDataContext> options)
        : base(options)
        {

        }
        public DbSet<Make> Makes { get; private set; }
        public DbSet<Car> Cars { get; private set; }

        
    }
}
