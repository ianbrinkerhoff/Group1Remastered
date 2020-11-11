using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Typing.Pages
{
    public class EnterNameModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            string uName = Request.Form["UserName"].ToString();

            UserStatus.currentUser = uName;
            UserStatus.loggedIn = true;

            return RedirectToPage("/Game");
        }
    }
}
