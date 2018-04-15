using System.Collections.Generic;

namespace DAL
{
    using System.ComponentModel.DataAnnotations;
    public class GearBox
    {
        [Key] public int GearBoxId { get; set; }
        [Required] public string Type { get; set; }
    }
}
