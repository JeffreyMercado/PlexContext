using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class VersionedMetadataItem
    {
        public long Id { get; set; }
        public long? MetadataItemId { get; set; }
        public long? GeneratorId { get; set; }
        public long? TargetTagId { get; set; }
        public long? State { get; set; }
        public long? StateContext { get; set; }
        public long? SelectedMediaId { get; set; }
        public long? VersionMediaId { get; set; }
        public long? MediaDecision { get; set; }
        public long? FileSize { get; set; }
    }
}
