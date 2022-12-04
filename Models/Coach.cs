using System;
using System.ComponentModel.DataAnnotations;

namespace FSystem.Models
{
    public class Coach
    {
        public int CoachId{get;set;}
        [Required]
        public string LastName{get;set;}
        [Required]

        public string FirstName{get;set;}
        [Required]

        public int Salary{get;set;}
    }
}