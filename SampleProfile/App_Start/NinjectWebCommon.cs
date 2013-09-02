using System.Data.Entity;
using NPatterns.ObjectRelational;
using NPatterns.ObjectRelational.EF;
using SampleProfile.Domain;
using SampleProfile.Domain.Repositories;
using SampleProfile.Domain.Repositories.Interfaces;


[assembly: WebActivator.PreApplicationStartMethod(typeof(SampleProfile.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivator.ApplicationShutdownMethodAttribute(typeof(SampleProfile.App_Start.NinjectWebCommon), "Stop")]

namespace SampleProfile.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        public static IKernel Kernel
        {
            get { return bootstrapper.Kernel; }
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
            
            RegisterServices(kernel);
            return kernel;
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<DbContext>().To<UsersContext>().InRequestScope();
            kernel.Bind<UsersContext>().ToSelf().InRequestScope();
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();

            kernel.Bind<IUserProfileRepository>().To<UserProfileRepository>();
            kernel.Bind<IProfileRepository>().To<ProfileRepository>();
            kernel.Bind<IProgrammingSkillRepository>().To<ProgrammingSkillRepository>();
            kernel.Bind<IProgrammingKnowledgeRepository>().To<ProgrammingKnowledgeRepository>();
            kernel.Bind<IExperienceRepository>().To<ExperienceRepository>();
        }        
    }
}
