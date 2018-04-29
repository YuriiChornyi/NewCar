namespace DALF
{
    using System.Collections.Generic;
    public interface ICarRepository : IRepository<Car>
    {
        IEnumerable<Car> GetByCarSalonId(int id);
        IEnumerable<Car> GetByCarClass(string carclass);
        IEnumerable<Car> GetByManufacturer(string manufacturer);
        IEnumerable<Car> GetByModel(string model);
        IEnumerable<Car> GetByYear(int year);
    }
}
