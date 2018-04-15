namespace DALF
{
    public class ColorTypeRepository : GenericRepository<ColorType>
    {
        public ColorTypeRepository(CarDbContext context) : base(context)
        {
        }
    }
}
