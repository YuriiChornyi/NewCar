namespace DAL
{
    using System.ComponentModel.DataAnnotations;
    public class Transmition
    {
        [Key] public int ID { get; set; }
        [Required] public int GearBoxID { get; set; }
        [Required] public GearBox GearBox { get; set; }
        [Required] public int DriveWheelsID { get; set; }
        [Required] public DriveWheels DriveWheels { get; set; }
    }
}
