namespace DAL
{
    public class CompleteSetRepository : GenericRepository<CompleteSet>
    {
        public CompleteSetRepository(DbContext context) : base(context)
        {
        }
    }
}
