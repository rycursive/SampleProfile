using System.Linq;
using NPatterns.ObjectRelational.EF;
using SampleProfile.Domain.Repositories.Interfaces;
using SampleProfile.Model;

namespace SampleProfile.Domain.Repositories
{
    public class ProfileRepository : Repository<Profile>, IProfileRepository
    {
        public ProfileRepository(UsersContext context) : base(context)
        {
        }

        public IQueryable<Profile> Profiles { get { return AsQueryable(); } }
    }
}
