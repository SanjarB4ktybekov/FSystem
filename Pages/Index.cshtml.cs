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
    public class IndexModel : PageModel
    {
        private AppDbContext context { get; set; }
        public IndexModel(AppDbContext _context)
        {
            context = _context;
        }

        public List<Player> players { get; set; }
        public Coach coach { get; set; }
        public Balance balance{get;set;}

        public void OnGet()
        {
            players = context.Players.ToList();
            coach = context.Coaches.FirstOrDefault();
        }
        public IActionResult OnPost([FromRoute]int id)
        {
            OnGet();
            var p = context.Players.FirstOrDefault(f => f.PlayerId == id);
            context.Players.Remove(p);
            context.SaveChanges();
            return RedirectToPage("/Index");
        }       
    }
}
