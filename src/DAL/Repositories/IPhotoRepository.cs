using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public interface IPhotoRepository : IRepository<Photo>
    {
        IEnumerable<string> GetPhotosByCarId(int carId);
    }
}
