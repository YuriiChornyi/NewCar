using Microsoft.EntityFrameworkCore;

namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {
        private readonly DbContext _db;
        public CarRepository(DbContext context) : base(context)
        {
            _db = context;
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _db.Set<Car>().ToList(); //.Include(x=> x.Color).Include(x=> x.Transmition).Include(x=>x.CompleteSet).Include(x=> x.CarPhotos).ToList(); 
        }

        public IEnumerable<Car> GetByCarSalonId(int id)
        {
            return from salon in _db.Set<Car>()
                   where salon.CarSalonId == id
                   select new Car();
        }

        public IEnumerable<Car> GetByCarClass(string carclass)
        {
            return from vehicleclass in _db.Set<Car>()
                   where vehicleclass.CarClass.Contains(carclass)
                   select new Car();
        }

        public IEnumerable<Car> GetByManufacturer(string manufacturer)
        {
            return from manufacturername in _db.Set<Car>()
                   where manufacturername.ManufacturerName.Contains(manufacturer)
                   select new Car();
        }

        public IEnumerable<Car> GetByModel(string model)
        {
            return from modelname in _db.Set<Car>()
                   where modelname.ManufacturerName.Contains(model)
                   select new Car();
        }

        public IEnumerable<Car> GetByYear(int year)
        {
            return from caryear in _db.Set<Car>()
                   where caryear.ProductionTime.Year == year
                   select new Car();
        }
    }
}
