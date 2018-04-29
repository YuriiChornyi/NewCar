namespace DALF
{
    public class EngineRepository : GenericRepository<Engine>
    {
        public EngineRepository(CarDbContext context) : base(context)
        {
        }
    }
}
