using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class Tagging
    {
        public long Id { get; set; }
        public long? MetadataItemId { get; set; }
        public long? TagId { get; set; }
        public long? Index { get; set; }
        public string Text { get; set; }
        public long? TimeOffset { get; set; }
        public long? EndTimeOffset { get; set; }
        public string ThumbUrl { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string ExtraData { get; set; }
    }
}
