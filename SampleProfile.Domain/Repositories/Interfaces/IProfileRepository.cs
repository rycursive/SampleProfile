using System.Linq;
using NPatterns.ObjectRelational;
using SampleProfile.Model;

namespace SampleProfile.Domain.Repositories.Interfaces
{
    public interface IProfileRepository: IRepository<Profile>
    {
        IQueryable<Profile> Profiles { get; } 
    }
}
