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
    internal class MakeRepository : Repository<Make> , IMakeRepository
    {
        public MakeRepository(CrudVehicleDataContext dbContext) : base(dbContext)
        {

        }

        public Make GetByName(string name)
        {
            return dataset.FirstOrDefault(x => x.Name == name);

        }

        public bool ExistsWithName(string name, int id = 0)
        {
            var makes = dataset.Where(x => x.Name == name);
            if (id != 0)
                return makes.Any(make => make.Id != id);
            return makes.Any();
        }
    }
}
