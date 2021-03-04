using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BootstrapDemo.Pages
{
    public class BootstrapModel : PageModel
    {
        private readonly ILogger<BootstrapModel> _logger;

        public BootstrapModel(ILogger<BootstrapModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            _logger.LogWarning("On Post Called!!!!");
        }
    }
}