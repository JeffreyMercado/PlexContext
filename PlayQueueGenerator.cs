using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class PlayQueueGenerator
    {
        public long Id { get; set; }
        public long? PlaylistId { get; set; }
        public long? MetadataItemId { get; set; }
        public string Uri { get; set; }
        public long? Limit { get; set; }
        public byte[] Continuous { get; set; }
        public double? Order { get; set; }
        public byte[] CreatedAt { get; set; }
        public byte[] UpdatedAt { get; set; }
        public long? ChangedAt { get; set; }
        public byte[] Recursive { get; set; }
        public long? Type { get; set; }
        public string ExtraData { get; set; }
    }
}
