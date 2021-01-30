using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Library
{
    public partial class MediaItemSetting
    {
        public long Id { get; set; }
        public long? AccountId { get; set; }
        public long? MediaItemId { get; set; }
        public string Settings { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
