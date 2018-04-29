namespace DALF
{
    using System.Collections.Generic;
    public interface ICarSalonRepository : IRepository<CarSalon>
    {
        IEnumerable<CarSalon> GetByCity(string city);
    }
}
