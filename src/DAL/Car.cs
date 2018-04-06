namespace DAL
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    class Car
    {
        [Key] public int ID { get; set; }
        [Required] public string ModelName { get; set; }
        [Required] public string ManufacturerName { get; set; }
        [Required] public int BodyID { get; set; }

        public virtual Body Body { get; set; }
        [Required] public int ColorID { get; set; }
        public virtual Color Color { get; set; }

        [Required] public int CompleteSetID { get; set; }

        public virtual CompleteSet CompleteSet { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public float Price { get; set; }

        [Required] public int TransmitionID { get; set; }
        public Transmition Transmition { get; set; }

        [Required] public int EngineID { get; set; }
        public virtual Engine Engine { get; set; }
        [Required] public int CarSalonID { get; set; }
        public virtual CarSalon CarSalon { get; set; }

        public string CarClass { get; set; }

        public virtual ICollection<string> Photos { get; set; }

    }
}
