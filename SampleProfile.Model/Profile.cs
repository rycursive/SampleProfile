using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SampleProfile.Model
{
    public class Profile
    {
        public int ProfileId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Summary { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public Sex Gender { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }

        [UIHint("MultilineText")]
        public string HomeAddress { get; set; }

        public string Education { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "LinkIn")]
        public string LinkinAddress { get; set; }

        [UIHint("MultilineText")]
        public string Hobbies { get; set; }

        public byte[] ImageData { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string ImageMimeType { get; set; }

        public int UserId { get; set; }
        public virtual UserProfile UserProfile { get; set; }

        public virtual ICollection<ProgrammingSkill> ProgrammingSkills { get; set; }
        public virtual ICollection<ProgrammingKnowledge> ProgrammingKnowledges { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
    }
    public enum Sex
    {
        Male,
        Female
    }
}
