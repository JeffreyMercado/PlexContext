using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class SchemaMigration
    {
        public string Version { get; set; }
        public string RollbackSql { get; set; }
        public bool? OptimizeOnRollback { get; set; }
    }
}
