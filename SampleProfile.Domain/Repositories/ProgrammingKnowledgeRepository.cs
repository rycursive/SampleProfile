using System.Linq;
using NPatterns.ObjectRelational.EF;
using SampleProfile.Domain.Repositories.Interfaces;
using SampleProfile.Model;

namespace SampleProfile.Domain.Repositories
{
    public class ProgrammingKnowledgeRepository : Repository<ProgrammingKnowledge>, IProgrammingKnowledgeRepository
    {
        public ProgrammingKnowledgeRepository(UsersContext context) : base(context)
        {
        }

        public IQueryable<ProgrammingKnowledge> ProgrammingKnowledges { get { return AsQueryable(); } }
    }
}
