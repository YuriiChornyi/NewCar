using System.Collections.Generic;

namespace DALF
{
    using System.ComponentModel.DataAnnotations;
    public class Color
    {
        [Key] public int ColorId { get; set; }
        [Required] public string ColorCode { get; set; }
        public int ColorTypeId { get; set; }
        public virtual ColorType ColorType { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
