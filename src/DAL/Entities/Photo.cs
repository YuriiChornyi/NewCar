using System.Collections.Generic;

namespace DAL
{
    using System.ComponentModel.DataAnnotations;
    public class Photo
    {
        [Key] public int PhotoId { get; set; }
        [Required] public string PhotoURL { get; set; }

        public int CarPhotoId { get; set; }

        public ICollection<CarPhoto> CarPhoto { get; set; }
    }
}
