using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class MediaPartSetting
    {
        public long Id { get; set; }
        public long? AccountId { get; set; }
        public long? MediaPartId { get; set; }
        public long? SelectedAudioStreamId { get; set; }
        public long? SelectedSubtitleStreamId { get; set; }
        public string Settings { get; set; }
        public byte[] CreatedAt { get; set; }
        public byte[] UpdatedAt { get; set; }
        public long? ChangedAt { get; set; }
    }
}
