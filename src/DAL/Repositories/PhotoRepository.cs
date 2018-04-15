using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    using DAL.Repositories;
    public class PhotoRepository : GenericRepository<Photo>, IPhotoRepository
    {
        private DbContext _db;
        public PhotoRepository(DbContext context) : base(context)
        {
            _db = context;
        }

        public IEnumerable<string> GetPhotosByCarId(int carId)
        {
            return _db.Photos.Where(x => x.CarId == carId).Select(x => x.PhotoURL);
        }
    }
}
