namespace DALF
{
    using System.Collections.Generic;
    public interface IDriveWheelsRepository : IRepository<DriveWheels>
    {
        IEnumerable<DriveWheels> GetByType(string type);
    }
}
