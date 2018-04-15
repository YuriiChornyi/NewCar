using System.Collections.Generic;

namespace DALF
{
    using System.ComponentModel.DataAnnotations;
    public class Body
    {
        [Key]
        public int BodyId { get; set; }
        [Required]
        public string Type { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

    }
}
