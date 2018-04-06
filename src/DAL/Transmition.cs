namespace DAL
{
    using System.ComponentModel.DataAnnotations;
    class Transmition
    {
        [Key] public int ID { get; set; }
        [Required] public int GearBoxID { get; set; }
        [Required] public GearBox GearBox { get; set; }
        [Required] public int DriveWeelsID { get; set; }
    }
}
