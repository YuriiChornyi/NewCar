namespace DALF
{
    using System.ComponentModel.DataAnnotations;
    public class ColorType
    {
        [Key] public int ColorTypeId { get; set; }
        [Required] public string Type { get; set; }
    }
}
