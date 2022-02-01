using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Infrastructure.Data;
using Infrastructure.Repositories.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(CrudVehicleDataContext dbContext) : base(dbContext)
        {

        }

        public Car GetByName(string name)
        {
            return dataset.FirstOrDefault(x => x.Model == name);

        }

        public bool ExistsWithName(string name, int id = 0) 
        {
            var vehicles = dataset.Where(x => x.Model == name );
            if (id != 0)
                return vehicles.Any(vehicle => vehicle.Id != id);
            return vehicles.Any();
        }
    }
}
