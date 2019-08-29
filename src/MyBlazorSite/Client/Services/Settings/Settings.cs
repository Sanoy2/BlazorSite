using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazorSite.Client.Services.Settings
{
    public class Settings
    {
        public IEnumerable<string> SupportedLanguages { get; protected set; }

        public Settings()
        {
            SupportedLanguages = new List<string>
            {
                "en",
                "pl"
            };
        }
    }
}
