using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatKodukuje.Models
{
    public class MathHack
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public datetime OptionalStartDate { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public string Location { get; set; }
        public int NumOfEmp { get; set; }
        public int ContactNum { get; set; }
        public List<Candidate> Candidates { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }

    }
}
