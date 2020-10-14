using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Typing.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (UserStatus.loggedIn == true)
            {
                UserStatus.loggedIn = true;
            }
            else
            {
                UserStatus.loggedIn = false;
                UserStatus.registered = false;
                UserStatus.currentUser = null;
            }

        }
    }
}
