using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleProfile.Model;

namespace SampleProfile.ViewModels
{
    public class SkillViewModel
    {
        public ProgrammingSkill ProgrammingSkill { get; set; }
        public string TitleColor { get; set; }
        public string BarColor { get; set; }
    }
}