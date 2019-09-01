using MyBlazorSite.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazorSite.Client.Services
{
    public interface ILinksProvider
    {
        IEnumerable<Link> Links{ get; }
    }
}
