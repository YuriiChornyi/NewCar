namespace DAL
{
    using System.Collections.Generic;
    using System.Linq;

    class CarSalonRepository : GenericRepository<CarSalon>, ICarSalonRepository
    {
        private readonly DbContext _db;
        public CarSalonRepository(DbContext context) : base(context)
        {
            _db = context;
        }

        public IEnumerable<CarSalon> GetByCity(string city)
        {
            return from salons in _db.Set<CarSalon>()
                   where salons.City.Contains(city)
                   select new CarSalon();
        }
    }
}
