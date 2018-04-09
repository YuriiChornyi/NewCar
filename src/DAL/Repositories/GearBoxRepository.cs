namespace DAL
{
    public class GearBoxRepository:GenericRepository<GearBox>
    {
        public GearBoxRepository(DbContext context) : base(context)
        {
        }
    }
}
