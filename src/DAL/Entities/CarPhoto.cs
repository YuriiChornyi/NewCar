using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
   public class CarPhoto
    {
        [Key]
        public int CarPhotoId { get; set; }

        [Required] public int CarId { get; set; }
        [Required]
        public virtual ICollection<Car> Cars { get; set; }
        [Required] public int PhotoId { get; set; }
        [Required]
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
