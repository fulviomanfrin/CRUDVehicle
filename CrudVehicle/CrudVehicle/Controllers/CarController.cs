using ApplicationCore.InputModels;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Services;
using ApplicationCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CrudVehicle.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : Controller
    {
        
        private ICarRepository _repository;
        private ICarService _carService;
        //private readonly ILogger<CarController> _logger;

        public CarController(ICarRepository repository, ICarService carService)
        {
            _repository = repository;
            _carService = carService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var vehicles = _repository.FindAll();
            var viewModels = vehicles.Select(vehicle =>
                new CarViewModel
                {
                    Id = vehicle.Id,
                    Model = vehicle.Model,
                    MakeId = vehicle.MakeId,
                    DoorQty = vehicle.DoorQty,
                    TransmissionType = vehicle.TransmissionType,
                    Year = vehicle.Year,
                    FuelType = vehicle.FuelType,


                } );
            return Ok(viewModels);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var car = _repository.FindById(id);
            if (car == null) return NotFound();
            return Ok(car);
        }

        [HttpGet("GetByName/{model}")]
        public ActionResult GetByName(string model)
        {
            var car = _repository.GetByName(model);
            if (car == null) return NotFound();
            return Ok(car);
        }

        [HttpPost]
        public ActionResult Post([FromBody] CarInputModel input)
        {
            try
            {
                if (input == null) return BadRequest();
                var result = _carService.SaveCar(input);

                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
           var result = _carService.Delete(id);
            return Ok(result);
        }




    }
}
