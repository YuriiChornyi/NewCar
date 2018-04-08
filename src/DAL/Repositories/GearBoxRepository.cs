namespace DAL
{
    class GearBoxRepository:GenericRepository<GearBox>
    {
        public GearBoxRepository(DbContext context) : base(context)
        {
        }
    }
}
