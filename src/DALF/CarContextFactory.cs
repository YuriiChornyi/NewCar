using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Text;

namespace DALF
{

    public class CarContextFactory : IDbContextFactory<CarDbContext>
    {
        public CarDbContext Create()
        {
            return new CarDbContext(
                "Server=DESKTOP-P2VVU6U;Integrated Security=SSPI;Database=NewCarDB;Trusted_Connection=True;");
        }
    }
}