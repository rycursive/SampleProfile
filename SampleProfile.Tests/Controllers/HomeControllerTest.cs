using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NPatterns.ObjectRelational;
using NUnit.Framework;
using SampleProfile;
using SampleProfile.Controllers;
using SampleProfile.Domain.Repositories.Interfaces;
using SampleProfile.Model;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SampleProfile.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        private Mock<IUnitOfWork> _unitOfWork;
        private Mock<IProfileRepository> _profileRepository;

        [SetUp]
        public void Setup()
        {
            _unitOfWork = new Mock<IUnitOfWork>();
            _profileRepository = new Mock<IProfileRepository>();

            _profileRepository.SetupGet(p => p.Profiles).Returns(new[]
                    {
                        new Profile {ProfileId = 1, FirstName = "Seksan"}
                    }.AsQueryable());
        }

        [Test]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController(_unitOfWork.Object, _profileRepository.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;
            var profile = result.Model as Profile;

            // Assert
            Assert.IsNotNull(profile);
            Assert.AreEqual(1, profile.ProfileId);
        }

        
    }
}
