using System;
using System.Collections.Generic;

namespace CoCApp.Domain
{
    public class Inspector
    {
        public Guid Id { get; set; }
        public List<InspectorSkill> Skills { get; set; }
    }
}
