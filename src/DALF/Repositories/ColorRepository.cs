namespace DALF
{
    public class ColorRepository:GenericRepository<Color>
    {
        public ColorRepository(CarDbContext context) : base(context)
        {
        }
    }
}
