﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProfile.Model
{
    public class ProgrammingSkill
    {
        public int ProgrammingSkillId { get; set; }

        public string Name { get; set; }

        [Range(0,100)]
        public int Level { get; set; }

        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
