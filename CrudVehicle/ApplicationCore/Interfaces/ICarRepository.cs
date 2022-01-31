using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface ICarRepository : IRepository<Car>
    {
        Car GetByName(string name);
        bool ExistsWithName(string name, int id = 0);
    }
}
