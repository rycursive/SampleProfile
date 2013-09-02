using System.Linq;
using NPatterns.ObjectRelational;
using SampleProfile.Model;

namespace SampleProfile.Domain.Repositories.Interfaces
{
    public interface IProgrammingSkillRepository : IRepository<ProgrammingSkill>
    {
        IQueryable<ProgrammingSkill> ProgrammingSkills { get; } 
    }
}
