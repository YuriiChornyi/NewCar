namespace DAL
{
    public class EngineRepository : GenericRepository<Engine>
    {
        public EngineRepository(DbContext context) : base(context)
        {
        }
    }
}
