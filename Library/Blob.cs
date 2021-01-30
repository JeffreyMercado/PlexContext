using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Library
{
    public partial class Blob
    {
        public long Id { get; set; }
        public byte[] Content { get; set; }
        public string LinkedType { get; set; }
        public long? LinkedId { get; set; }
        public string LinkedGuid { get; set; }
        public DateTime? CreatedAt { get; set; }
        public long? BlobType { get; set; }
    }
}
