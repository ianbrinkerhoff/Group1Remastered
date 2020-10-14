using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Typing.Pages
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            UserStatus.loggedIn = false;
            UserStatus.currentUser = null;
            UserStatus.registered = false;

            return RedirectToPage("/Index");
        }
    }
}