using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatKodukuje.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DisplayName("Minimum Salary")]
        public decimal MinSalary { get; set; }

        [DisplayName("Maximum Salary")]
        public decimal MaxSalary { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
