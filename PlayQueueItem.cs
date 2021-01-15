using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class PlayQueueItem
    {
        public long Id { get; set; }
        public long? PlayQueueId { get; set; }
        public long? MetadataItemId { get; set; }
        public double? Order { get; set; }
        public byte[] UpNext { get; set; }
        public long? PlayQueueGeneratorId { get; set; }
    }
}
