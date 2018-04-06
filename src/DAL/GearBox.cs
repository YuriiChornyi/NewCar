namespace DAL
{
    using System.ComponentModel.DataAnnotations;
    class GearBox
    {
        [Key] public int ID { get; set; }
        [Required] public string Type { get; set; }
    }
}
