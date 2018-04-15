using System.Collections.Generic;

namespace DAL
{
    using System.ComponentModel.DataAnnotations;
    public class Color
    {
        [Key] public int ColorId { get; set; }
        [Required] public string ColorCode { get; set; }
        public int ColorTypeId { get; set; }
        public ColorType ColorType { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
