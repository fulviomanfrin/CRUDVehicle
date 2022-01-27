using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Infrastructure.Data;
using Infrastructure.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(CrudVehicleDataContext dbContext) : base(dbContext)
        {

        }
    }
}
