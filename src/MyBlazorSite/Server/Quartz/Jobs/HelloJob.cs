using Microsoft.Extensions.DependencyInjection;
using MyBlazorSite.Server.Services;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazorSite.Server.Quartz.Jobs
{
    [DisallowConcurrentExecution]
    public class HelloJob : IJob
    {
        // Inject the DI provider
        private readonly IServiceProvider _provider;
        public HelloJob(IServiceProvider provider)
        {
            _provider = provider;
        }

        public Task Execute(IJobExecutionContext context)
        {
            // Create a new scope
            using (var scope = _provider.CreateScope())
            {
                // Resolve the Scoped service
                var logger = scope.ServiceProvider.GetService<IScope>();
                logger.Log("Hello World! I am a Job!");
            }

            return Task.CompletedTask;
        }
    }
}
