namespace DAL
{
    class TransmitionRepository : GenericRepository<Transmition>
    {
        public TransmitionRepository(DbContext context) : base(context)
        {
        }
    }
}
