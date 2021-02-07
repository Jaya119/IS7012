using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatKodukuje.Models
{
    public class Industry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MathHack> MathHacks { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
