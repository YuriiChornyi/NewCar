namespace DAL
{
    using System.ComponentModel.DataAnnotations;
    public class Photo
    {
        [Key] public int ID { get; set; }
        [Required] public string PhotoURL { get; set; }

        [Required] public int CarID { get; set; }
        public virtual Car Car { get; set; }
    }
}
