using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudVehicle.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : Controller
    {
        
        private ICarRepository _repository;
        //private readonly ILogger<CarController> _logger;

        public CarController(ICarRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_repository.List());
        }
    }
}
