using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class MediaItemSetting
    {
        public long Id { get; set; }
        public long? AccountId { get; set; }
        public long? MediaItemId { get; set; }
        public string Settings { get; set; }
        public byte[] CreatedAt { get; set; }
        public byte[] UpdatedAt { get; set; }
    }
}
