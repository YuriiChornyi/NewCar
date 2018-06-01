using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using DALF;
using Newtonsoft.Json;

namespace Service
{
    public class CarDto
    {
        public CarDto()
        {
        }

        public CarDto(int id, string manufacturerName, string modelName, string carSalonName, int carSalonId, string driveWheels, float price, List<string> photos, string colorType, string color, string bodyType, string carClass, string engineFuel, float engineValue, string gearBox)
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
            EngineFuel = engineFuel;
            EngineValue = engineValue;
            GearBox = gearBox;
        }

        public int Id { get; set; }
        public string ManufacturerName { get; set; }
        public string ModelName { get; set; }
        public string CarSalonName { get; set; }
        public int CarSalonId { get; set; }
        public string DriveWheels { get; set; }
        public float Price { get; set; }
        public List<string> Photos { get; set; }
        public string ColorType { get; set; }
        public string Color { get; set; }
        public string BodyType { get; set; }
        public string CarClass { get; set; }
        public string EngineFuel { get; set; }
        public float EngineValue { get; set; }
        public string GearBox { get; set; }
    }
}
