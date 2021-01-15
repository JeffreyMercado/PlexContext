using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class MediaProviderResource
    {
        public long Id { get; set; }
        public long? ParentId { get; set; }
        public long? Type { get; set; }
        public long? Status { get; set; }
        public long? State { get; set; }
        public string Identifier { get; set; }
        public string Protocol { get; set; }
        public string Uri { get; set; }
        public string Uuid { get; set; }
        public string ExtraData { get; set; }
        public DateTime? LastSeenAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public byte[] Data { get; set; }
    }
}
