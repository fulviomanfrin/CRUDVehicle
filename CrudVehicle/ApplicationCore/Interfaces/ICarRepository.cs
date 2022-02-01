using ApplicationCore.Models;

namespace ApplicationCore.Interfaces
{
    public interface ICarRepository : IRepository<Car>
    {
        Car GetByName(string name);
        bool ExistsWithName(string name, int id = 0);
    }
}
