using System;

namespace DAL
{
    using Microsoft.EntityFrameworkCore.Proxies;
    using Microsoft.EntityFrameworkCore;
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        private readonly DbContextOptions<DbContext> _options;
        public DbContext()
            : base()
        { }

        public DbContext(DbContextOptions<DbContext> options)
            : base(options)
        {
            _options = options;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<Body> Bodies { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarSalon> CarSalons { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ColorType> ColorTypes { get; set; }
        public DbSet<CompleteSet> CompleteSets { get; set; }
        public DbSet<DriveWheels> DriveWheelses { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<GearBox> GearBoxs { get; set; }
        public DbSet<Transmition> Transmitions { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<CarPhoto> CarPhotos { get; set; }
    }
}
