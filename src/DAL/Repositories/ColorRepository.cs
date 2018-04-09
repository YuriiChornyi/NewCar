namespace DAL
{
    public class ColorRepository:GenericRepository<Color>
    {
        public ColorRepository(DbContext context) : base(context)
        {
        }
    }
}
