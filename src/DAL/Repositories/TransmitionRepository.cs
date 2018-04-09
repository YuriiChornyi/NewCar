namespace DAL
{
    public class TransmitionRepository : GenericRepository<Transmition>
    {
        public TransmitionRepository(DbContext context) : base(context)
        {
        }
    }
}
