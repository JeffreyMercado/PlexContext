using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class MediaStream
    {
        public long Id { get; set; }
        public long? StreamTypeId { get; set; }
        public long? MediaItemId { get; set; }
        public string Url { get; set; }
        public string Codec { get; set; }
        public string Language { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? Index { get; set; }
        public long? MediaPartId { get; set; }
        public long? Channels { get; set; }
        public long? Bitrate { get; set; }
        public long? UrlIndex { get; set; }
        public bool? Default { get; set; }
        public bool? Forced { get; set; }
        public string ExtraData { get; set; }
    }
}
