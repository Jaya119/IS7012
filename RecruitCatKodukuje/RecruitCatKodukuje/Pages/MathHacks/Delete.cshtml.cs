using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatKodukuje.Data;
using RecruitCatKodukuje.Models;

namespace RecruitCatKodukuje.Pages.MathHacks
{
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatKodukuje.Data.RecruitCatKodukujeContext _context;

        public DeleteModel(RecruitCatKodukuje.Data.RecruitCatKodukujeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MathHack MathHack { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MathHack = await _context.MathHack
                .Include(m => m.Industry).FirstOrDefaultAsync(m => m.Id == id);

            if (MathHack == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MathHack = await _context.MathHack.FindAsync(id);

            if (MathHack != null)
            {
                _context.MathHack.Remove(MathHack);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
