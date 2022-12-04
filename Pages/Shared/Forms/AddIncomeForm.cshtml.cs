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
    public class AddIncomeForm : PageModel
    {
        AppDbContext context{get;set;}

        public AddIncomeForm(AppDbContext _context)
        {
            context = _context;
        }
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public Income Income{get;set;}
        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            context.Incomes.Add(Income);
            context.SaveChanges();
            return RedirectToPage("/Index");
        }
    }
}