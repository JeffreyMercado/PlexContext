using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Library
{
    public partial class SyncedMetadataItem
    {
        public long Id { get; set; }
        public long? SyncListId { get; set; }
        public long? SyncItemId { get; set; }
        public long? MetadataItemId { get; set; }
        public long? ChangedAt { get; set; }
        public long? FirstPackagedAt { get; set; }
        public long? State { get; set; }
        public long? StateContext { get; set; }
        public long? SelectedMediaId { get; set; }
        public long? SelectedPartId { get; set; }
        public long? MediaDecision { get; set; }
        public long? FileSize { get; set; }
        public string MediaAnalysisExtraData { get; set; }
        public long? ParentId { get; set; }
        public long? LibrarySectionId { get; set; }
    }
}
