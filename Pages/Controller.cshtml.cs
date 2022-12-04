using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FSystem.Pages
{
    public class ControllerModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        
        public void OnGet()
        {

        }
    }
}
