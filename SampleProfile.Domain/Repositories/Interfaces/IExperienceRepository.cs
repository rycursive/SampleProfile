using System.Linq;
using NPatterns.ObjectRelational;
using SampleProfile.Model;

namespace SampleProfile.Domain.Repositories.Interfaces
{
    public interface IExperienceRepository : IRepository<Experience>
    {
        IQueryable<Experience> Experiences { get; }
    }
}
