using ClientsIntegrationTests.SetUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsIntegrationTests.model
{
    class Selector
    {
        public string Name { get; set; }
        public SelectorType Type { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
