using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Library
{
    public partial class SyncedAncestorItem
    {
        public long Id { get; set; }
        public long? SyncListId { get; set; }
        public long? MetadataItemId { get; set; }
        public long? ChangedAt { get; set; }
        public long? ReferenceCount { get; set; }
        public long? FirstPackagedAt { get; set; }
        public long? ParentId { get; set; }
        public long? State { get; set; }
    }
}
