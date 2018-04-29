namespace DALF
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {
        private readonly CarDbContext _carDb;
        public CarRepository(CarDbContext context) : base(context)
        {
            _carDb = context;
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _carDb.Set<Car>().ToList(); //.Include(x=> x.Color).Include(x=> x.Transmition).Include(x=>x.CompleteSet).Include(x=> x.CarPhotos).ToList(); 
        }

        public IEnumerable<Car> GetByCarSalonId(int id)
        {
            return from salon in _carDb.Set<Car>()
                   where salon.CarSalonId == id
                   select new Car();
        }

        public IEnumerable<Car> GetByCarClass(string carclass)
        {
            return from vehicleclass in _carDb.Set<Car>()
                   where vehicleclass.CarClass.Contains(carclass)
                   select new Car();
        }

        public IEnumerable<Car> GetByManufacturer(string manufacturer)
        {
            return from manufacturername in _carDb.Set<Car>()
                   where manufacturername.ManufacturerName.Contains(manufacturer)
                   select new Car();
        }

        public IEnumerable<Car> GetByModel(string model)
        {
            return from modelname in _carDb.Set<Car>()
                   where modelname.ManufacturerName.Contains(model)
                   select new Car();
        }

        public IEnumerable<Car> GetByYear(int year)
        {
            return from caryear in _carDb.Set<Car>()
                   where caryear.ProductionTime.Year == year
                   select new Car();
        }
    }
}
