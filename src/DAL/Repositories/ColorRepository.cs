namespace DAL
{
    class ColorRepository:GenericRepository<Color>
    {
        public ColorRepository(DbContext context) : base(context)
        {
        }
    }
}
