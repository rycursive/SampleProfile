using System.Linq;
using NPatterns.ObjectRelational.EF;
using SampleProfile.Domain.Repositories.Interfaces;
using SampleProfile.Model;

namespace SampleProfile.Domain.Repositories
{
    public class UserProfileRepository : Repository<UserProfile>, IUserProfileRepository
    {
        public UserProfileRepository(UsersContext context) : base(context)
        {
        }

        public IQueryable<UserProfile> Profiles { 
            get { return AsQueryable(); }}
    }
}
