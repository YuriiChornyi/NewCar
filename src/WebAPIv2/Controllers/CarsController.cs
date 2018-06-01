using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using DataService;
using DALF;
using Service;

namespace WebAPIv2.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class CarsController : ApiController
    {
        private CarDbContext _db;
        private CarsService _service;
        public CarsController(CarDbContext db)
        {
            _db = db;
            _service = new CarsService(_db);
        }
        public CarsController()
        {
            _db = new CarDbContext();
            _service = new CarsService(_db);
        }

        // GET: api/Cars
        public ICollection<CarDto> GetCars()
        {

            return _service.GetAllCars();
        }


        // GET: api/Cars/5
        [ResponseType(typeof(Car))]
        public IHttpActionResult GetCar([FromUri]int id)
        {
            var returnitem=_service.GetCarById(id);
            if (returnitem == null)
            {
                return NotFound();
            }


            return Ok(returnitem);
        }

        // PUT: api/Cars/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCar([FromUri]int id, [FromBody]Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != car.CarId)
            {
                return BadRequest();
            }

            _db.Entry(car).State = EntityState.Modified;

            try
            {
                _db.SaveChanges();
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

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Cars
        [ResponseType(typeof(Car))]
        public IHttpActionResult PostCar([FromBody]Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _db.Cars.Add(car);
            _db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = car.CarId }, car);
        }

        // DELETE: api/Cars/5
        [ResponseType(typeof(Car))]
        public IHttpActionResult DeleteCar(int id)
        {
            Car car = _db.Cars.Find(id);
            if (car == null)
            {
                return NotFound();
            }

            _db.Cars.Remove(car);
            _db.SaveChanges();

            return Ok(car);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CarExists(int id)
        {
            return _db.Cars.Count(e => e.CarId == id) > 0;
        }
    }
}