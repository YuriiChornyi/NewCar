namespace DAL
{
    using System.ComponentModel.DataAnnotations;
    public class DriveWheels
    {
        [Key] public int ID { get; set; }
        [Required] public string Type { get; set; }
    }
}
