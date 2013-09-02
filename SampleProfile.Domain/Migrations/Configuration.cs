using System.Collections.Generic;
using SampleProfile.Model;

namespace SampleProfile.Domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SampleProfile.Domain.UsersContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SampleProfile.Domain.UsersContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            
            context.Profiles.AddOrUpdate(new Profile
                {
                    ProfileId = 7,
                    FirstName = "Seksan",
                    LastName = "Pinthong",
                    Gender = Sex.Male,
                    Birthday = new DateTime(1985, 4, 9),
                    UserId = 1,
                    Education = "Bachelor of Engineering",
                    EmailAddress = "Sighart@gmail.com",
                    HomeAddress = "72/1 Moo 2 Wangchan, Wangchan District, Rayong 21210, Thailand",
                    PhoneNumber = "0892552702",
                    LinkinAddress = "th.linkedin.com/in/seksan/",
                    Summary = "Microsoft .NET developer with {exp} experience in development of multi-tier database-driven systems " +
                              "with rich UI. Thorough understanding of technologies and Development Lifecycle of the software" +
                              "design process include requirements definition, prototyping, proof of concept, design," +
                              " interface implementation, testing, and maintenance",
                    ProgrammingSkills = new List<ProgrammingSkill>()
                        {
                            new ProgrammingSkill
                                {
                                    Name = "C#",
                                    Level = 100
                                },
                            new ProgrammingSkill
                                {
                                    Name = "WPF",
                                    Level = 100
                                },
                            new ProgrammingSkill
                                {
                                    Name = "ASP.NET MVC",
                                    Level = 90
                                },
                                new ProgrammingSkill
                                {
                                    Name = "CSS3",
                                    Level = 70
                                },
                                new ProgrammingSkill
                                {
                                    Name = "HTML5",
                                    Level = 80
                                },
                                new ProgrammingSkill
                                {
                                    Name = "Java Script",
                                    Level = 75
                                },
                                new ProgrammingSkill
                                {
                                    Name = "Python",
                                    Level = 50
                                }
                        },
                    ProgrammingKnowledges = new List<ProgrammingKnowledge>()
                        {
                            new ProgrammingKnowledge()
                                {
                                    Title = "WEB DEVELOPMENT",
                                    Detail = "ASP.NET MVC 4.5, SilverLight,MS Azure, HTML5, CSS, Javascript, Ajax, Jquery, Ninject, Knockout, WCF, XML/SOAP Web Services, IIS."
                                },
                            new ProgrammingKnowledge()
                                {
                                    Title = "WINDOWS DEVELOPMENT",
                                    Detail = "WPF, WinForms."
                                },
                            new ProgrammingKnowledge()
                                {
                                    Title = "DATABASES",
                                    Detail = "Ms SQL, Ms Access, Oracle, My SQL, ADO.Net Entity Framework 5, Linq to Sql."
                                },
                            new ProgrammingKnowledge()
                                {
                                    Title = "IDE, COMPONENTS, TOOLS",
                                    Detail = "Visual Studio 2012, Expression Studio (Web, Blend), Delphi, C++ Builder."
                                },
                        },
                    Experiences = new List<Experience>()
                        {
                            new Experience
                                {
                                    CompanyName = "Vizrt Thailand",
                                    Postion = "Software Developer",
                                    StartDate = new DateTime(2010, 02, 15),
                                    EndDate = new DateTime(2013, 07, 31),
                                    Detail =
                                        "- Working as an extension team in Bangkok together with the VCP development team in Bergen, " +
                                        "Norway which is developing on the Viz Content Pilot product backlog. The Viz Content Pilot " +
                                        "offers the optimal environment to create, manage, and deliver high volumes of top quality content. " +
                                        "It supports live and taped news, sports, election, and other broadcast productions. The content creation " +
                                        "can be totally independent from the design department." +
                                        "- Develop the Digital Signage Client project which manage extensive " +
                                        "the content creation, management, control and monitoring solution that " +
                                        "can now be turned into a full 3D interactive kiosk. "
                                },
                            new Experience
                                {
                                    CompanyName = "Toyota Tsusho Electronics (Thailand) Co,Ltd.",
                                    Postion = "Software Developer",
                                    StartDate = new DateTime(2008, 04, 01),
                                    EndDate = new DateTime(2010, 02, 14),
                                    Detail =
                                        "- Built productive, high performing software development team for high quality deliverables in C language." +
                                        "- Developed project plan and monitor project activities by using risk, issue, and change management." +
                                        "- Analyzed specifications and requirements documents.",

                                },
                        },
                });
        }
    }
}
