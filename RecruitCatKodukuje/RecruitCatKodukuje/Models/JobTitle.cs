using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatKodukuje.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
