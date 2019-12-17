using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace CodingDojo.Models
{
    public class Shop
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Item { get; set; }
        [Required]
        public double Price { get; set; }

        public Shop()
        {
        }
    }
}
