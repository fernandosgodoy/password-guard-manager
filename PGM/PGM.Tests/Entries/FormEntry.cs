using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGM.Tests.Entries
{
    internal struct FormEntry
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Expires { get; set; }
        public short? ExpiresDays { get; set; }
        public string Password { get; set; }
    }
}
