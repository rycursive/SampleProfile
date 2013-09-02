using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NPatterns.ObjectRelational;
using SampleProfile.Domain.Repositories.Interfaces;
using SampleProfile.Model;
using SampleProfile.ViewModels;

namespace SampleProfile.Controllers
{
    public class HomeController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private IProfileRepository _profileRepository;

        public HomeController(IUnitOfWork uow, IProfileRepository profile)
        {
            _unitOfWork = uow;
            _profileRepository = profile;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "My Profile";
            var profile = _profileRepository.Profiles.FirstOrDefault();

            return View(profile);
        }

        public ActionResult Skill(ICollection<ProgrammingSkill> skills)
        {
            var titleBarColor = new[]
                {
                    new{ skillName="C#", skillColor = "palette-nephritis"},
                    new{ skillName="WPF", skillColor = "palette-belize-hole"},
                    new{ skillName="ASP.NET MVC", skillColor = "palette-wisteria"},
                    new{ skillName="CSS3", skillColor = "palette-midnight-blue"},
                    new{ skillName="HTML5", skillColor = "palette-orange"},
                    new{ skillName="Java Script", skillColor = "palette-pumpkin"},
                    new{ skillName="Python", skillColor = "palette-pomegranate"}
                };
            var barColor = new[]
                {
                    new{ skillName="C#", skillColor = "palette-emerald"},
                    new{ skillName="WPF", skillColor = "palette-peter-river"},
                    new{ skillName="ASP.NET MVC", skillColor = "palette-amethyst"},
                    new{ skillName="CSS3", skillColor = "palette-wet-asphalt"},
                    new{ skillName="HTML5", skillColor = "palette-sun-flower"},
                    new{ skillName="Java Script", skillColor = "palette-carrot"},
                    new{ skillName="Python", skillColor = "palette-alizarin"}
                };
            var viewModel = from skill in skills
                            join title in titleBarColor on skill.Name equals title.skillName
                            join bar in barColor on skill.Name equals bar.skillName
                            select new SkillViewModel
                                    {
                                        ProgrammingSkill = skill,
                                        TitleColor = title.skillColor,
                                        BarColor = bar.skillColor
                                    };
            
            return PartialView("Skill", viewModel);
        }

        public ActionResult Knowledge(ICollection<ProgrammingKnowledge> knowledges)
        {
            var images = new[]
                {
                    new {Name = "Web development", src = "Compas@2x"},
                    new {Name = "Windows Development", src = "Gift-Box@2x"},
                    new {Name = "Databases", src = "Pensils@2x"},
                    new {Name = "IDE, Components, Tools", src = "Map@2x"}
                };
            var viewModel = from knowledge in knowledges
                            join img in images on knowledge.Title equals img.Name
                            select new KnowledgeViewModel()
                                {
                                    Knowledge = knowledge,
                                    imageSrc = img.src
                                };

            return PartialView("Knowledge", viewModel);
        }
    }
}
