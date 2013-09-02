using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProfile.Model
{
    public class Experience
    {
        public int ExperienceId { get; set; }
        public string CompanyName { get; set; }
        public string Postion { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Detail { get; set; }

        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
