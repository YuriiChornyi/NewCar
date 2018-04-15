using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DAL;
using DataService;

namespace WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Cars")]
    public class CarsController : Controller
    {
        private readonly DAL.UnitOfWork _unitOfWork;
        private readonly CarsService _carsService;

        public CarsController(DAL.DbContext context)
        {
            _carsService = new CarsService(context);
            _unitOfWork = new UnitOfWork(context);
        }

        // GET: api/Cars
        [HttpGet]
        public IEnumerable<CarDto> GetCars()
        {
            _unitOfWork.Cars.GetAllCars();
            return _carsService.GetAllCars();
        }

        // GET: api/Cars/5
        [HttpGet("{id}")]
        public IActionResult GetCar([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var car = _unitOfWork.Cars.Get(id);

            if (car == null)
            {
                return NotFound();
            }

            return Ok(car);
        }

        // PUT: api/Cars/5
        [HttpPut("{id}")]
        public IActionResult PutCar([FromRoute] int id, [FromBody] Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != car.CarId)
            {
                return BadRequest();
            }

            _unitOfWork.Cars.Update(car);

            try
            {
                _unitOfWork.Commit();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cars
        [HttpPost]
        public IActionResult PostCar([FromBody] Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.Cars.Add(car);
            _unitOfWork.Commit();

            return CreatedAtAction("GetCar", new { id = car.CarId }, car);
        }

        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCar([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var car = _unitOfWork.Cars.Get(id);
            if (car == null)
            {
                return NotFound();
            }

            _unitOfWork.Cars.Remove(id);
            _unitOfWork.Commit();

            return Ok(car);
        }

        private bool CarExists(int id)
        {
            if (_unitOfWork.Cars.Get(id) != null)
                return true;
            return false;
        }
    }
}