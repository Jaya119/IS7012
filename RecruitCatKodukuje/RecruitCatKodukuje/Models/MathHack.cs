using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatKodukuje.Models
{
    public class MathHack
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime OptionalStartDate { get; set; }

        [DisplayName("Minimum Salary")]
        public decimal MinSalary { get; set; }

        [DisplayName("Minimum Salary")]
        public decimal MaxSalary { get; set; }
        public string Location { get; set; }

        [DisplayName("Employee Count")]
        public int NumOfEmp { get; set; }
        
        [DisplayName("Contact")]
        public int ContactNum { get; set; }
        public List<Candidate> Candidates { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }

    }
}
