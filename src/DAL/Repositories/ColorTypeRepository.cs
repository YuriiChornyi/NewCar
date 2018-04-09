namespace DAL
{
    public class ColorTypeRepository : GenericRepository<ColorType>
    {
        public ColorTypeRepository(DbContext context) : base(context)
        {
        }
    }
}
