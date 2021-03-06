﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Library
{
    public partial class MediaStreamSetting
    {
        public long Id { get; set; }
        public long? AccountId { get; set; }
        public long? MediaStreamId { get; set; }
        public string ExtraData { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
