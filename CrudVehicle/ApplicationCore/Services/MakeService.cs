using ApplicationCore.InputModels;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Services;
using ApplicationCore.Models;
using System;

namespace ApplicationCore.Services
{
    internal class MakeService : IMakeService
    {

        public IMakeRepository _repository;
        public MakeService(IMakeRepository repository)
        {
            _repository = repository;
        }

        public bool SaveMake(MakeInputModel input)
        {
            StartValidations(input);

            if (input.Id == null)
            {


                var make = new Make( input.Name);
            }
            else
            {

                var make = _repository.FindById(input.Id.Value);
                if (make == null)
                {
                    throw new Exception();
                }


                make.UpdateData(input.Name);
                _repository.Update(make);
            }

            return true;

        }

        public bool Delete(int id)
        {
            var make = _repository.FindById(id);
            if (make == null)
            {
                throw new Exception();
            }
            _repository.Delete(make);
            return true;
        }

        public void StartValidations(MakeInputModel input)
        {

            if (_repository.ExistsWithName(input.Name, input.Id ?? 0))
                throw new Exception("Make already exists in records");

        }

    }

}
}
