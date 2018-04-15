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
        //   var photos= _db.CarPhotos.Where(x => x.CarId == carId);//.Include(x => x.Photos);
        //    var res1=photos.Include(X => X.Photos);
        //    foreach (var item in res1)
        //    {
                
        //    }
            var photos = _db.CarPhotos.Where(x => x.CarId == carId).Select(y => y.Photo.PhotoURL);
        return photos;
            //return _db.CarPhotos.Where(x => x.CarId == carId).Select(x=>x.Photos);
        }
    }
}
