using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL
{
    class Body
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Type { get; set; }

    }
}
