namespace DALF
{
    public class TransmitionRepository : GenericRepository<Transmition>
    {
        public TransmitionRepository(CarDbContext context) : base(context)
        {
        }
    }
}
