namespace DAL
{
    using Microsoft.EntityFrameworkCore;
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<DbContext> options)
            : base(options)
        { }

        public DbSet<Body> Bodies { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarSalon> CarSalons { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ColorType> ColorTypes { get; set; }
        public DbSet<CompleteSet> CompleteSets { get; set; }
        public DbSet<DriveWheels> DriveWheelses { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<GearBox> GearBoxes { get; set; }
        public DbSet<Transmition> Transmitions { get; set; }
    }
}
