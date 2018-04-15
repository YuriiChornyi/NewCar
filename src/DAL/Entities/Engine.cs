using System.Collections.Generic;

namespace DAL
{
    using System.ComponentModel.DataAnnotations;
    public class Engine
    {
        [Key] public int EngineId { get; set; }
        [Required] public float Value { get; set; }
        [Required] public float ValueByHundred { get; set; }
        [Required] public string FuelType { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
