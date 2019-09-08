using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazorSite.Server.Services
{
    public interface IMyLogger
    {
        void Log(string text);
    }
}
