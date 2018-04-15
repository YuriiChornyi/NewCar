using System.Collections.Generic;

namespace DAL
{
    using System.ComponentModel.DataAnnotations;
    public class Transmition
    {
        [Key] public int TransmitionId{ get; set; }
        [Required] public int GearBoxID { get; set; }
        public GearBox GearBox { get; set; }
        [Required] public int DriveWheelsId { get; set; }
        public DriveWheels DriveWheels { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
