using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazorSite.Server.Services
{
    public class Scoped : IScope
    {
        private readonly ILogger<Scoped> _logger;
        public Scoped(ILogger<Scoped> logger)
        {
            _logger = logger;
        }

        public void Log(string text)
        {
            _logger.LogInformation(text);
        }
    }
}
