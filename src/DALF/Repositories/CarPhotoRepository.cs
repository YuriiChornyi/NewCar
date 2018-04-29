namespace DALF
{
    public class CarPhotoRepository : GenericRepository<CarPhoto>
    {
        public CarPhotoRepository(CarDbContext context) : base(context)
        {
        }
    }
}
