namespace DAL
{
    class EngineRepository : GenericRepository<Engine>
    {
        public EngineRepository(DbContext context) : base(context)
        {
        }
    }
}
