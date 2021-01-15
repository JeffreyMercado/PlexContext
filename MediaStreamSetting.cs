using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class MediaStreamSetting
    {
        public long Id { get; set; }
        public long? AccountId { get; set; }
        public long? MediaStreamId { get; set; }
        public string ExtraData { get; set; }
        public byte[] CreatedAt { get; set; }
        public byte[] UpdatedAt { get; set; }
    }
}
