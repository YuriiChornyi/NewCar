using System.Collections.Generic;
using DAL;

namespace DataService
{
    public class CarDto
    {
        public CarDto(int id, string manufacturerName, string modelName, string carSalonName, int carSalonId, string driveWheels, float price, IEnumerable<string> photos, string colorType, string color, string bodyType, string carClass)
        {
            Id = id;
            ManufacturerName = manufacturerName;
            ModelName = modelName;
            CarSalonName = carSalonName;
            CarSalonId = carSalonId;
            DriveWheels = driveWheels;
            Price = price;
            Photos = photos;
            ColorType = colorType;
            Color = color;
            BodyType = bodyType;
            CarClass = carClass;
        }

        public int Id { get; set; }
        public string ManufacturerName { get; set; }
        public string ModelName { get; set; }
        public string CarSalonName { get; set; }
        public int CarSalonId { get; set; }
        public string DriveWheels { get; set; }
        public float Price { get; set; }
        public IEnumerable<string> Photos { get; set; }
        public string ColorType { get; set; }
        public string Color { get; set; }

        public int BodyId { get; set; }
        public string BodyType { get; set; }

        public string CarClass { get; set; }
    }
}
