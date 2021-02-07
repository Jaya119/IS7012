using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatKodukuje.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public datetime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public datetime OptionalStartDate { get; set; }
        public decimal TargetSalary { get; set; }
        public int? WorkExp { get; set; }
        public MathHack MathHack { get; set; }
        public int MathHackId { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }
    }
}
