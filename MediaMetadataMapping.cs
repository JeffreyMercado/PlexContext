using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class MediaMetadataMapping
    {
        public long Id { get; set; }
        public string MediaGuid { get; set; }
        public string MetadataGuid { get; set; }
        public byte[] CreatedAt { get; set; }
        public byte[] UpdatedAt { get; set; }
    }
}
