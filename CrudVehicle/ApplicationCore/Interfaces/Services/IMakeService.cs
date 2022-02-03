using ApplicationCore.InputModels;

namespace ApplicationCore.Interfaces.Services
{
    internal interface IMakeService
    {
        bool SaveMake(MakeInputModel input);
        bool Delete(int id);
    }
}
