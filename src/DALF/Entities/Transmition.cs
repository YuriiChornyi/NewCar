using System.Collections.Generic;

namespace DALF
{
    using System.ComponentModel.DataAnnotations;
    public class Transmition
    {
        [Key] public int TransmitionId{ get; set; }
        [Required] public int GearBoxID { get; set; }
        public virtual GearBox GearBox { get; set; }
        [Required] public int DriveWheelsId { get; set; }
        public virtual DriveWheels DriveWheels { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
