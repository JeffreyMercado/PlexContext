using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class MetadataItemView
    {
        public long Id { get; set; }
        public long? AccountId { get; set; }
        public string Guid { get; set; }
        public long? MetadataType { get; set; }
        public long? LibrarySectionId { get; set; }
        public string GrandparentTitle { get; set; }
        public long? ParentIndex { get; set; }
        public string ParentTitle { get; set; }
        public long? Index { get; set; }
        public string Title { get; set; }
        public string ThumbUrl { get; set; }
        public byte[] ViewedAt { get; set; }
        public string GrandparentGuid { get; set; }
        public byte[] OriginallyAvailableAt { get; set; }
        public long? DeviceId { get; set; }
    }
}
