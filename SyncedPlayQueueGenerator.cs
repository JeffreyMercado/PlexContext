using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class SyncedPlayQueueGenerator
    {
        public long Id { get; set; }
        public long? SyncListId { get; set; }
        public long? SyncItemId { get; set; }
        public long? PlaylistId { get; set; }
        public long? PlayQueueGeneratorId { get; set; }
        public long? ChangedAt { get; set; }
        public long? State { get; set; }
        public long? StateContext { get; set; }
        public long? FirstPackagedAt { get; set; }
    }
}
