using System.Data.Entity;
using SampleProfile.Model;

namespace SampleProfile.Domain
{
    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<ProgrammingSkill> ProgrammingSkills { get; set; }
        public DbSet<ProgrammingKnowledge> ProgrammingKnowledges { get; set; }
        public DbSet<Experience> Experiences { get; set; }
    }

}
