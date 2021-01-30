using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Library
{
    public partial class MetadataItemSetting
    {
        public long Id { get; set; }
        public long? AccountId { get; set; }
        public string Guid { get; set; }
        public double? Rating { get; set; }
        public long? ViewOffset { get; set; }
        public long? ViewCount { get; set; }
        public DateTime? LastViewedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? SkipCount { get; set; }
        public DateTime? LastSkippedAt { get; set; }
        public long? ChangedAt { get; set; }
        public string ExtraData { get; set; }
        public DateTime? LastRatedAt { get; set; }
    }
}
