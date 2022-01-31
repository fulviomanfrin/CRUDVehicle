using ApplicationCore.InputModels;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Services;
using ApplicationCore.Models;
using System;

namespace ApplicationCore.Services
{
    public class CarService : ICarService
    {
        public ICarRepository _repository;
        public CarService(ICarRepository repository)
        {
            _repository = repository;
        }

        public bool SaveCar(CarInputModel input)
        {
            StartValidations(input);

            if (input.Id == null)
            {
                

                var car = new Car(input.Model, input.MakeId, input.DoorQty, input.TransmissionType, input.Year, input.FuelType);
                _repository.Create(car);
            }
            else
            {
                
                var car = _repository.FindById(input.Id.Value);
                if (car == null)
                {
                    throw new Exception();
                }


                car.UpdateData(input.Model, input.MakeId, input.DoorQty, input.TransmissionType, input.Year, input.FuelType);
                _repository.Update(car);
            }

            return true;

        }

        public bool Delete(int id)
        {
            var car = _repository.FindById(id);
            if (car == null)
            {
                throw new Exception();
            }
            _repository.Delete(car);
            return true;
        }
        
        public void StartValidations(CarInputModel input)
        {

            if (_repository.ExistsWithName(input.Model, input.Id ?? 0))
                throw new Exception("Model already exists in records");

        }

    }
}
