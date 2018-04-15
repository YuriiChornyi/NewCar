namespace DALF
{
    using System.Collections.Generic;
    using System.Linq;

    public class CarSalonRepository : GenericRepository<CarSalon>, ICarSalonRepository
    {
        private readonly CarDbContext _carDb;
        public CarSalonRepository(CarDbContext context) : base(context)
        {
            _carDb = context;
        }

        public IEnumerable<CarSalon> GetByCity(string city)
        {
            return from salons in _carDb.Set<CarSalon>()
                   where salons.City.Contains(city)
                   select new CarSalon();
        }
    }
}
