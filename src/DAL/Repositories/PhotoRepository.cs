namespace DAL
{
    class PhotoRepository : GenericRepository<Photo>
    {
        public PhotoRepository(DbContext context) : base(context)
        {
        }
    }
}
