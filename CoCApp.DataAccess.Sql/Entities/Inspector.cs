using System;
using System.Collections.Generic;

namespace CoCApp.DataAccess.Sql.Entities
{
    public class Inspector : DbEntity
    {
        public Guid Id { get; set; }
        public virtual List<InspectorSkill> Skills { get; set; }
    }
}
