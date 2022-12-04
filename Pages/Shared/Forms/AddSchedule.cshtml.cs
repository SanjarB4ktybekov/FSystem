using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using FSystem.Models;

namespace FSystem.Pages
{
    public class AddScheduleForm : PageModel
    {
        AppDbContext context{get;set;}

        public AddScheduleForm(AppDbContext _context)
        {
            context = _context;
        }
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public Schedule _Schedule{get;set;}
        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            context.Schedules.Add(_Schedule);
            context.SaveChanges();
            return RedirectToPage("/Index");
        }
    }
}