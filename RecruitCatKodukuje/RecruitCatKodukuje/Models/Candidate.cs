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
        [Required(ErrorMessage = "You need a first name")]
        [StringLength(20)]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "You need a last name")]
        [StringLength(20)]
        public string LastName { get; set; }

        public int Age { get; set; }

        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("SSN")]
        [RegularExpression("^\\d{3}-?\\d{2}-?\\d{4}$", ErrorMessage = "Please enter a valid SSN")]
        [StringLength(11, MinimumLength = 9, ErrorMessage = "Please enter a valid SSN")]
        [Required(ErrorMessage = "Social Security Number is Required")]
        public string SocialSecurityNumber { get; set; }

        public string Gender { get; set; }

        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime OptionalStartDate { get; set; }

        [DisplayName("Salary")]
        public decimal TargetSalary { get; set; }

        [DisplayName("Work Experience")]
        public int? WorkExp { get; set; }

        [DisplayName("Math Hack")]
        [StringLength(20)]
        public MathHack MathHack { get; set; }
        public int MathHackId { get; set; }

        [StringLength(20)]
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
       public string MaskedSocialSecurityNumber
        {
            get
            {
                if (SocialSecurityNumber?.Length < 4)
                    {
                    return SocialSecurityNumber;
                    }
                return "***-**-" + SocialSecurityNumber.Substring(SocialSecurityNumber.Length - 4, 4);
            }
        }
    }
}
