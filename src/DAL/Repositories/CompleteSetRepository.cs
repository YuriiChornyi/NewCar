namespace DAL
{
    class CompleteSetRepository : GenericRepository<CompleteSet>
    {
        public CompleteSetRepository(DbContext context) : base(context)
        {
        }
    }
}
