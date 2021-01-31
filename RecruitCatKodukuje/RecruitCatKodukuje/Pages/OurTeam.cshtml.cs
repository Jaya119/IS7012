using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RecruitCatKodukuje.Pages
{
    public class OurTeamModel : PageModel
    {
        public IActionResult OnPost()
        {
            return this.RedirectToAction("Index", "Home");
        }
        public void OnGet()
        {
        }
    }
}
