using Castle.Windsor;
using Quartz;
using Quartz.Spi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazorSite.Server.Quartz
{
    public class WindsorJobFactory : IJobFactory
    {
        private readonly IWindsorContainer _container;

        public WindsorJobFactory(IWindsorContainer container)
        {
            _container = container;
        }

        public IJob NewJob(TriggerFiredBundle bundle)
        {
            return (IJob)_container.Resolve(bundle.JobDetail.JobType);
        }

        public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
        {
            return (IJob)_container.Resolve(bundle.JobDetail.JobType);
        }

        public void ReturnJob(IJob job)
        { }
    }
}
