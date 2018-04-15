using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DALF
{
   public class CarPhoto
    {
        [Key]
        public int CarPhotoId { get; set; }

        [Required] public int CarId { get; set; }
        
        public virtual Car Cars { get; set; }
        [Required] public int PhotoId { get; set; }
        
        public virtual Photo Photos { get; set; }
    }
}
