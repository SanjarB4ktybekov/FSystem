using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using FSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace FSystem.Pages
{
    public class AddFootballerFormModel : PageModel
    {
        AppDbContext context { get; set; }

        public AddFootballerFormModel(AppDbContext _context)
        {
            context = _context;
        }
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public Player Player{get;set;}
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

           // Player = new Player{FirstName = model.FirstName, LastName = model.LastName, Age = model.Age, Salary = model.Salary, Position = model.Position};
            context.Players.Add(Player);
            context.SaveChanges();
            return RedirectToPage("/Index");
        }

        public class InputModel
        {
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
}