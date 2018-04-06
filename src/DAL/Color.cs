namespace DAL
{
    using System.ComponentModel.DataAnnotations;
    class Color
    {
        [Key] public int ID { get; set; }
        [Required] public string ColorCode { get; set; }
        [Required] public int ColorTypeID { get; set; }
        public ColorType ColorType { get; set; }
    }
}
