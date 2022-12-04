using System;
using System.ComponentModel.DataAnnotations;

namespace FSystem.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        public string LastName { get; set; }
        [Required]
        [Range(18, 50)]

        public int Age { get; set; }
        [Required]

        public int Salary { get; set; }

        [Required]
        public string Position { get; set; }
    }
}