using System.Collections.Generic;

namespace DALF
{
    using System.ComponentModel.DataAnnotations;
    public class CompleteSet
    {
        [Required] public int CompleteSetId { get; set; }
        [Required] public string Description { get; set; }
        public string Photo { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
