using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Library
{
    public partial class PlayQueue
    {
        public long Id { get; set; }
        public string ClientIdentifier { get; set; }
        public long? AccountId { get; set; }
        public long? PlaylistId { get; set; }
        public long? SyncItemId { get; set; }
        public long? PlayQueueGeneratorId { get; set; }
        public long? GeneratorStartIndex { get; set; }
        public long? GeneratorEndIndex { get; set; }
        public long? GeneratorItemsCount { get; set; }
        public byte[] GeneratorIds { get; set; }
        public long? Seed { get; set; }
        public long? CurrentPlayQueueItemId { get; set; }
        public long? LastAddedPlayQueueItemId { get; set; }
        public long? Version { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? MetadataType { get; set; }
        public long? TotalItemsCount { get; set; }
        public byte[] GeneratorGeneratorIds { get; set; }
        public string ExtraData { get; set; }
    }
}
