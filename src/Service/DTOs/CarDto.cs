using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using DALF;
using Newtonsoft.Json;

namespace Service
{
    //[JsonObject(MemberSerialization.OptOut)]
    public class CarDto
    {
      //  [JsonConstructor]
        public CarDto(int id, string manufacturerName, string modelName, string carSalonName, int carSalonId, string driveWheels, float price, List<string> photos, string colorType, string color, string bodyType, string carClass)
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
        //[JsonProperty]
        public int Id { get; set; }
        //[JsonProperty]
        public string ManufacturerName { get; set; }
        //[JsonProperty]
        public string ModelName { get; set; }
        //[JsonProperty]
        public string CarSalonName { get; set; }
        //[JsonProperty]
        public int CarSalonId { get; set; }
        //[JsonProperty]
        public string DriveWheels { get; set; }
        //[JsonProperty]
        public float Price { get; set; }
        //[JsonProperty]
        public List<string> Photos { get; set; }
        //[JsonProperty]
        public string ColorType { get; set; }
        //[JsonProperty]
        public string Color { get; set; }
        //[JsonProperty]
        public string BodyType { get; set; }
        //[JsonProperty]
        public string CarClass { get; set; }
    }
}
