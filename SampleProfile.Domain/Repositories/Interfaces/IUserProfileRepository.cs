using System.Linq;
using NPatterns.ObjectRelational;
using SampleProfile.Model;

namespace SampleProfile.Domain.Repositories.Interfaces
{
    public interface IUserProfileRepository: IRepository<UserProfile>
    {
        IQueryable<UserProfile> Profiles { get; }
    }
}
