using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class SyncSchemaVersion
    {
        public long Id { get; set; }
        public long? Version { get; set; }
        public long? ChangedAt { get; set; }
    }
}
