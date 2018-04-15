using System;

namespace DALF
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    public class CarDbContext : System.Data.Entity.DbContext
    {
        public CarDbContext()
            : base("name=DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
        }

        public CarDbContext(string constring)
            : base(constring)
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
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
