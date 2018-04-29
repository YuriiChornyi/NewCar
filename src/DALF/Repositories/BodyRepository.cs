namespace DALF
{
    public class BodyRepository : GenericRepository<Body>
    {
        public BodyRepository(CarDbContext carDbContext) : base(carDbContext)
        { }
    }
}
