using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace OhMyGlass.Pages
{
    public class ShowcaseModel : PageModel
    {
        private readonly ILogger<ShowcaseModel> _logger;

        public ShowcaseModel(ILogger<ShowcaseModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet(string password = null)
        {
            return Page();
        }
    }
}
