namespace DAL
{
    using System.ComponentModel.DataAnnotations;
    public class Body
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Type { get; set; }

    }
}
