using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazorSite.Server.Services
{
    interface IScope
    {
        void Log(string text);
    }
}
