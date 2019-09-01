using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlazorSite.Client.Models;

namespace MyBlazorSite.Client.Services
{
    public class LinksProvider : ILinksProvider
    {
        public IEnumerable<Link> Links { get; }

        public LinksProvider()
        {
            Links = new List<Link>
            {
                new Link()
                {
                    Url = "https://github.com/Sanoy2",
                    Icon = "fa fa-github",
                    Title = "github"
                },
                new Link()
                {
                    Url = "https://www.linkedin.com/in/ktomkow/",
                    Icon = "fa fa-linkedin-square",
                    Title = "linkedin"
                }
            };
        }
    }
}
