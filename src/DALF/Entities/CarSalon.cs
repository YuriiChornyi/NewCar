namespace DALF
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class CarSalon
    {
        [Key]
        public int CarSalonId { get; set; }
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(45)]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Site { get; set; }

        public string City { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

    }
}
