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
    public class EditFootballerFormModel : PageModel
    {
        AppDbContext context { get; set; }

        public EditFootballerFormModel(AppDbContext _context)
        {
            context = _context;
        }
        [BindProperty]
        public Player Player{get;set;}
        public void OnGet(int id)
        {
           Player = context.Players.FirstOrDefault(f => f.PlayerId == id);
        }
        public IActionResult OnPost([FromRoute]int id)
        {
            var p = context.Players.FirstOrDefault(_p => _p.PlayerId == id);
            if(p == null)
            {
                System.Console.WriteLine("null");
                return Page();
            }
            if (!ModelState.IsValid)
            {
                return Page();
            }
            p.FirstName = Player.FirstName;
            p.LastName = Player.LastName;
            p.Age = Player.Age;
            p.Position = Player.Position;
            p.Salary = Player.Salary;
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