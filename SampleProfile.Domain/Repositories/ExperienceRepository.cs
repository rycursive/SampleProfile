using System.Data.Entity;
using System.Linq;
using NPatterns.ObjectRelational.EF;
using SampleProfile.Domain.Repositories.Interfaces;
using SampleProfile.Model;

namespace SampleProfile.Domain.Repositories
{
    public class ExperienceRepository : Repository<Experience>, IExperienceRepository
    {
        public ExperienceRepository(DbContext context) : base(context)
        {
        }

        public IQueryable<Experience> Experiences { get { return AsQueryable(); } }
    }
}
