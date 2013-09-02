using System.Linq;
using NPatterns.ObjectRelational.EF;
using SampleProfile.Domain.Repositories.Interfaces;
using SampleProfile.Model;

namespace SampleProfile.Domain.Repositories
{
    public class ProgrammingSkillRepository : Repository<ProgrammingSkill>, IProgrammingSkillRepository
    {
        public ProgrammingSkillRepository(UsersContext context) : base(context)
        {
        }

        public IQueryable<ProgrammingSkill> ProgrammingSkills { get { return AsQueryable(); }}
    }
}
