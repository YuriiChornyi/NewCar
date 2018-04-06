namespace DAL
{
    using System.ComponentModel.DataAnnotations;
    class Engine
    {
        [Key] public int ID { get; set; }
        [Required] public float Value { get; set; }
        [Required] public float ValueByHundred { get; set; }
        [Required] public string FuelType { get; set; }
    }
}
