using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePortalClient
{
    internal class DomainEntry : BusinessObject
    {
        internal DomainEntry(int id, string description)
            : base(id, description)
        {
        }
    }
}
