using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class MetadataItemSetting
    {
        public long Id { get; set; }
        public long? AccountId { get; set; }
        public string Guid { get; set; }
        public double? Rating { get; set; }
        public long? ViewOffset { get; set; }
        public long? ViewCount { get; set; }
        public byte[] LastViewedAt { get; set; }
        public byte[] CreatedAt { get; set; }
        public byte[] UpdatedAt { get; set; }
        public long? SkipCount { get; set; }
        public byte[] LastSkippedAt { get; set; }
        public long? ChangedAt { get; set; }
        public string ExtraData { get; set; }
        public byte[] LastRatedAt { get; set; }
    }
}
