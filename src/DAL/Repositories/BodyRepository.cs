using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DAL
{
    public class BodyRepository : GenericRepository<Body>
    {
        public BodyRepository(DbContext dbContext) : base(dbContext)
        { }
    }

}
