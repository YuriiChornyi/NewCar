namespace DALF
{
    using System.Collections.Generic;
    using System.Linq;

    public class DriveWheelsRepository : GenericRepository<DriveWheels>, IDriveWheelsRepository
    {
        private readonly CarDbContext _carDb;
        public DriveWheelsRepository(CarDbContext context) : base(context)
        {
            _carDb = context;
        }

        public IEnumerable<DriveWheels> GetByType(string type)
        {
            return from drivewheels in _carDb.Set<DriveWheels>()
                   where drivewheels.Type.Contains(type)
                   select new DriveWheels();
        }
    }
}
