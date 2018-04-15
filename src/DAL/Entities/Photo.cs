//using System.Collections.Generic;

//namespace DAL
//{
//    using System.ComponentModel.DataAnnotations;
//    public class Photo
//    {
//        [Key] public int PhotoId { get; set; }
//        [Required] public string PhotoURL { get; set; }

//        public int CarPhotoId { get; set; }

//        public CarPhoto CarPhoto { get; set; }
//    }
//}

namespace DAL
{
    using System.ComponentModel.DataAnnotations;
    public class Photo
    {
        [Key] public int Id { get; set; }
        [Required] public string PhotoURL { get; set; }

        [Required] public int CarId { get; set; }
        public virtual Car Car { get; set; }
    }
}
