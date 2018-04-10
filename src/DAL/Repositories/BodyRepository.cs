namespace DAL
{
    public class BodyRepository : GenericRepository<Body>
    {
        public BodyRepository(DbContext dbContext) : base(dbContext)
        { }
    }
}
