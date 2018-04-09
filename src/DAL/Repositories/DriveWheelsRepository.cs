namespace DAL
{
    using System.Collections.Generic;
    using System.Linq;

    public class DriveWheelsRepository : GenericRepository<DriveWheels>, IDriveWheelsRepository
    {
        private readonly DbContext _db;
        public DriveWheelsRepository(DbContext context) : base(context)
        {
            _db = context;
        }

        public IEnumerable<DriveWheels> GetByType(string type)
        {
            return from drivewheels in _db.Set<DriveWheels>()
                   where drivewheels.Type.Contains(type)
                   select new DriveWheels();
        }
    }
}
