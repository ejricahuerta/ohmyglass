using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace OhMyGlass.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet(string password = null)
        {
            if(!string.IsNullOrEmpty(password) && password.Equals("ohmyglass")){
                 return Page();
            }
            
             if(DateTime.Now < DateTime.Parse("July 20,2020")){
                 return LocalRedirect(Url.Content("~/ComingSoon"));
            }
            return Page();
        }
    }
}
