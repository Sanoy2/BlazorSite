using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazorSite.Server.Services
{
    public class MyLogger : IMyLogger
    {
        private readonly ILogger logger;

        public MyLogger(ILogger logger)
        {
            this.logger = logger;
        }
        
        public void Log(string text)
        {
            logger.LogInformation($"Information, {text}");
        }
    }
}
