using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatKodukuje.Data;
using RecruitCatKodukuje.Models;

namespace RecruitCatKodukuje.Pages.Candidates
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatKodukuje.Data.RecruitCatKodukujeContext _context;

        public IndexModel(RecruitCatKodukuje.Data.RecruitCatKodukujeContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; }

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidate
                .Include(c => c.Industry)
                .Include(c => c.JobTitle)
                .Include(c => c.MathHack).ToListAsync();
        }
    }
}
