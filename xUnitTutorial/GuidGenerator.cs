using System;
using System.Collections.Generic;
using System.Text;

namespace xUnitTutorial
{
    public class GuidGenerator
    {
        public Guid RandomGuid { get; } = Guid.NewGuid();
    }
}
