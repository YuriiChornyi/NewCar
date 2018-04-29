using System.Collections.Generic;

namespace DALF
{
    using System.ComponentModel.DataAnnotations;
    public class Engine
    {
        [Key] public int EngineId { get; set; }
        [Required] public float Value { get; set; }
        [Required] public float ValueByHundred { get; set; }
        [Required] public string FuelType { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
