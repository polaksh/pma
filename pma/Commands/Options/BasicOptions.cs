using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pma.Commands.Options
{
    public class BasicOptions : CommandOptions
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string XPath { get; set; }
        public string CssLocator { get; set; }
    }
}
