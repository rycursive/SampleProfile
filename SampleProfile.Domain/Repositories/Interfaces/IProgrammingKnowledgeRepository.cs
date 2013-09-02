using System.Linq;
using NPatterns.ObjectRelational;
using SampleProfile.Model;

namespace SampleProfile.Domain.Repositories.Interfaces
{
    public interface IProgrammingKnowledgeRepository: IRepository<ProgrammingKnowledge>
    {
        IQueryable<ProgrammingKnowledge> ProgrammingKnowledges { get; } 
    }
}
