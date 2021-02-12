using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatKodukuje.Models;

namespace RecruitCatKodukuje.Data
{
    public class RecruitCatKodukujeContext : DbContext
    {
        public RecruitCatKodukujeContext (DbContextOptions<RecruitCatKodukujeContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatKodukuje.Models.MathHack> MathHack { get; set; }

        public DbSet<RecruitCatKodukuje.Models.JobTitle> JobTitle { get; set; }

        public DbSet<RecruitCatKodukuje.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatKodukuje.Models.Candidate> Candidate { get; set; }
    }
}
