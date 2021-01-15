using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class MediaSubscription
    {
        public long Id { get; set; }
        public double? Order { get; set; }
        public long? MetadataType { get; set; }
        public long? TargetMetadataItemId { get; set; }
        public long? TargetLibrarySectionId { get; set; }
        public long? TargetSectionLocationId { get; set; }
        public string ExtraData { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
