﻿using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using log4net.Config;
using NHibernate;
using NHibernate.Context;
using Ninject;
using Ninject.Activation;
using Ninject.Web.Common;
using TaskManager.Common;
using TaskManager.Common.Logging;
using TaskManager.Common.Security;
using TaskManager.Common.TypeMapping;
using TaskManager.Data.SqlServer.Mapping;
using TaskManager.Web.Api.InquiryProcessing;
using TaskManager.Web.Api.LinkServices;
using TaskManager.Web.Api.Security;
using TaskManager.Web.Common;
using TaskManager.Web.Common.Security;

namespace TaskManager.Web.Api.App_Start
{
	public class NinjectConfigurator
    {
        public void Configure(IKernel container)
        {
            AddBindings(container);
        }

        private void AddBindings(IKernel container)
        {
            ConfigureLog4net(container);
            ConfigureUserSession(container);
            ConfigureNHibernate(container);
            ConfigureAutoMapper(container);

            container.Bind<IDateTime>().To<DateTimeAdapter>().InSingletonScope();
            container.Bind<IBasicSecurityService>().To<BasicSecurityService>().InSingletonScope();
            container.Bind<IUpdateablePropertyDetector>().To<JObjectUpdateablePropertyDetector>().InSingletonScope();
            container.Bind<IPagedDataRequestFactory>().To<PagedDataRequestFactory>().InSingletonScope();
            container.Bind<ICommonLinkService>().To<CommonLinkService>().InRequestScope();
        }

        private void ConfigureLog4net(IKernel container)
        {
            XmlConfigurator.Configure();

            var logManager = new LogManagerAdapter();
            container.Bind<ILogManager>().ToConstant(logManager);
        }

        private void ConfigureNHibernate(IKernel container)
        {
            //var sessionFactory = Fluently.Configure()
            //    .Database(MsSqlConfiguration.MsSql2012.ConnectionString(c => c.FromConnectionStringWithKey("TaskManagerDb")))
            //    .CurrentSessionContext("web")
            //    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<TaskMap>())
            //    .BuildSessionFactory();

            //container.Bind<ISessionFactory>().ToConstant(sessionFactory);
            //container.Bind<ISession>().ToMethod(CreateSession).InRequestScope();
            //container.Bind<IActionTransactionHelper>().To<ActionTransactionHelper>();
        }

        private ISession CreateSession(IContext context)
        {
            var sessionFactory = context.Kernel.Get<ISessionFactory>();

            if (!CurrentSessionContext.HasBind(sessionFactory))
            {
                var session = sessionFactory.OpenSession();
                CurrentSessionContext.Bind(session);
            }

            return sessionFactory.GetCurrentSession();
        }

        private void ConfigureUserSession(IKernel container)
        {
            var userSession = new UserSession();
            container.Bind<IUserSession>().ToConstant(userSession).InSingletonScope();
            container.Bind<IWebUserSession>().ToConstant(userSession).InSingletonScope();
        }

        private void ConfigureAutoMapper(IKernel container)
        {
            container.Bind<IAutoMapper>().To<AutoMapperAdapter>().InSingletonScope();
        }
    }
}