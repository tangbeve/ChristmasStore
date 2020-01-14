using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasStore.Models
{
    public class Login
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 6, ErrorMessage = "Inputted Password incorrectly")]
        public string Password { get; set; }

        
    
    }
}
