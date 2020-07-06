using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace OhMyGlass.Pages
{
    public class ComingSoonModel : PageModel
    {
        private readonly ILogger<ComingSoonModel> _logger;

        public ComingSoonModel(ILogger<ComingSoonModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
