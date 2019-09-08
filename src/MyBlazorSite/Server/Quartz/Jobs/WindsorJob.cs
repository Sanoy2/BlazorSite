using Microsoft.Extensions.Logging;
using MyBlazorSite.Server.Services;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazorSite.Server.Quartz.Jobs
{
    public class WindsorJob : IJob
    {
        private readonly IMyLogger logger;

        public WindsorJob(IMyLogger logger)
        {
            this.logger = logger;
        }

        public Task Execute(IJobExecutionContext context)
        {
            logger.Log("Windsor job here");
            throw new NotImplementedException();
        }
    }
}
