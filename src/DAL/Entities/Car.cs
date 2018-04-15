//using System;
//using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore.Metadata.Internal;

//namespace DAL
//{
//    using System.Collections.Generic;
//    using System.ComponentModel.DataAnnotations;
//    public class Car
//    {
//        [Key] public int CarId { get; set; }
//        [Required] public string ModelName { get; set; }
//        [Required] public string ManufacturerName { get; set; }
//        [Required] [DataType(DataType.Date)] public DateTime ProductionTime { get; set; }
//        [ForeignKey("Body")]
//        public int BodyId { get; set; }
//        public Body Body { get; set; }
//        [ForeignKey("Color")]
//        public int ColorId { get; set; }
//        public Color Color { get; set; }
//        [ForeignKey("CompleteSet")]
//        public int CompleteSetId { get; set; }
//        public CompleteSet CompleteSet { get; set; }
//        [Required]
//        [DataType(DataType.Currency)]
//        public float Price { get; set; }
//        [ForeignKey("Transmition")]
//        public int TransmitionId { get; set; }
//        public Transmition Transmition { get; set; }
//        [ForeignKey("Engine")]
//        public int EngineId { get; set; }
//        public Engine Engine { get; set; }
//        [ForeignKey("CarSalon")]
//        public int CarSalonId { get; set; }
//        public CarSalon CarSalon { get; set; }
//        public string CarClass { get; set; }

//        //public CarPhoto CarPhoto { get; set; }
//    }
//}

using System;

namespace DAL
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Car
    {
        [Key] public int CarId { get; set; }
        [Required] public string ModelName { get; set; }
        [Required] public string ManufacturerName { get; set; }
        [Required] [DataType(DataType.Date)] public DateTime ProductionTime { get; set; }
        [Required] public int BodyId { get; set; }

        public virtual Body Body { get; set; }
        [Required] public int ColorId { get; set; }
        public virtual Color Color { get; set; }

        [Required] public int CompleteSetId { get; set; }

        public virtual CompleteSet CompleteSet { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public float Price { get; set; }

        [Required] public int TransmitionId { get; set; }
        public Transmition Transmition { get; set; }

        [Required] public int EngineId { get; set; }
        public Engine Engine { get; set; }
        [Required] public int CarSalonId { get; set; }
        public CarSalon CarSalon { get; set; }

        public string CarClass { get; set; }

        public ICollection<Photo> Photos { get; set; }

    }
}
