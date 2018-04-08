namespace DAL
{
    using System.ComponentModel.DataAnnotations;
    public class CompleteSet
    {
        [Required] public int ID { get; set; }
        [Required] public string Description { get; set; }
        public string Photo { get; set; }
    }
}
