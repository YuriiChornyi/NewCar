using System.Collections.Generic;

namespace DAL
{
    using System.ComponentModel.DataAnnotations;
    public class CompleteSet
    {
        [Required] public int CompleteSetId { get; set; }
        [Required] public string Description { get; set; }
        public string Photo { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
