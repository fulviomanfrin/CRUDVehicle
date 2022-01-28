using ApplicationCore.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Services
{
    public interface ICarService 
    {
        bool SaveCar(CarInputModel input);
        bool Delete(int id);
    }
}
