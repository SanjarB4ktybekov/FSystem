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
    public class ScheduleModel : PageModel
    {
        private AppDbContext context { get; set; }
        public List<Schedule> _Shedule{get;set;}
        public ScheduleModel(AppDbContext _context)
        {
            context = _context;
        }
        public void OnGet()
        {
           _Shedule = context.Schedules.ToList();
        }
    }
}
