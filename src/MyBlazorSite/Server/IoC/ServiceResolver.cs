using AutoMapper;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyBlazorSite.Server.Automapper;
using MyBlazorSite.Server.Quartz;
using MyBlazorSite.Server.Quartz.Jobs;
using MyBlazorSite.Server.Services;
using Quartz;
using Quartz.Impl;
using Quartz.Spi;
using System;
using System.Reflection;

namespace MyBlazorSite.Server.IoC
{
    public class ServiceResolver : IServiceProvider
    {
        private IWindsorContainer container;
        private IServiceProvider serviceProvider;

        public ServiceResolver(IServiceCollection services)
        {
            var assembly = Assembly.GetEntryAssembly();
            container = new WindsorContainer();

            container.Register(Component.For<IMapper>().Instance(AutoMapperConfig.Configure()).LifestyleSingleton());
            container.Register(Component.For<IMyLogger>().ImplementedBy<MyLogger>().LifestyleTransient());

            // Quartz
            container.Register(Component.For<IJobFactory>().ImplementedBy<WindsorJobFactory>().LifestyleSingleton());
            container.Register(Component.For<ISchedulerFactory>().ImplementedBy<StdSchedulerFactory>().LifestyleSingleton());
            container.Register(Component.For<IHostedService>().ImplementedBy<QuartzHostedService>().LifestyleSingleton());
            container.Register(Component.For<ILogger>().ImplementedBy<Logger<WindsorJob>>());
            container.Register(Component.For<WindsorJob>().LifestyleTransient());
            container.Register(Component.For<JobSchedule>().Instance(new JobSchedule(
                jobType: typeof(WindsorJob),
                cronExpression: "0/5 * * * * ?")));

            serviceProvider = WindsorRegistrationHelper.CreateServiceProvider(container, services);
        }

        public object GetService(Type serviceType)
        {
            return container.Resolve(serviceType);
        }

        public IServiceProvider GetServiceProvider()
        {
            return serviceProvider;
        }
    }
}