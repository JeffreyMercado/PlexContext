using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class MediaGrab
    {
        public long Id { get; set; }
        public string Uuid { get; set; }
        public long? Status { get; set; }
        public long? Error { get; set; }
        public long? MetadataItemId { get; set; }
        public long? MediaSubscriptionId { get; set; }
        public string ExtraData { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
