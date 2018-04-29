namespace DALF
{
    public class GearBoxRepository:GenericRepository<GearBox>
    {
        public GearBoxRepository(CarDbContext context) : base(context)
        {
        }
    }
}
