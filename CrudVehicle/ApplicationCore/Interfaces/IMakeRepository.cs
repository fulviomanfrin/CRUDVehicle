using ApplicationCore.Models;

namespace ApplicationCore.Interfaces
{
    public interface IMakeRepository: IRepository<Make>
    {
        Make GetByName(string name);
        bool ExistsWithName(string name, int id = 0);
    }
}
