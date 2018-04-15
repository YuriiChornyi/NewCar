namespace DAL
{
    class CarPhotoRepository : GenericRepository<CarPhoto>
    {
        public CarPhotoRepository(DbContext context) : base(context)
        {
        }
    }
}
