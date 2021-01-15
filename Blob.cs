using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class Blob
    {
        public long Id { get; set; }
        public byte[] Blob1 { get; set; }
        public string LinkedType { get; set; }
        public long? LinkedId { get; set; }
        public string LinkedGuid { get; set; }
        public byte[] CreatedAt { get; set; }
        public long? BlobType { get; set; }
    }
}
