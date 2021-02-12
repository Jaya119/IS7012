using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatKodukuje.Models
{
    public class Candidate
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public int Age { get; set; }

        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }

        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime OptionalStartDate { get; set; }

        [DisplayName("Salary")]
        public decimal TargetSalary { get; set; }

        [DisplayName("Work Experience")]
        public int? WorkExp { get; set; }

        [DisplayName("Math Hack")]
        public MathHack MathHack { get; set; }
        public int MathHackId { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
