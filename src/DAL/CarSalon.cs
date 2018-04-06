namespace DAL
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    class CarSalon
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(15)]
        public string PhoneNumber{ get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Site { get; set; }

        public virtual ICollection<Car> CarCollection { get; set; }

    }
}
