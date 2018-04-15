using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DALF.Repositories;

namespace DALF
{
    using DALF.Repositories;
    public class PhotoRepository : GenericRepository<Photo>, IPhotoRepository
    {
        private CarDbContext _carDb;
        public PhotoRepository(CarDbContext context) : base(context)
        {
            _carDb = context;
        }

        public IEnumerable<string> GetPhotosByCarId(int carId)
        {
            var res = _carDb.CarPhotos.Where(x => x.CarId == carId).Select(x => x.Photos);
            var res2 = _carDb.Photos;
            List<string> ret = new List<string>();
            foreach (var photo in res2)
            {
                ret.Add(photo.PhotoURL);
            }

            return ret;
        }
    }
}
