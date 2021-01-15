using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class MediaPart
    {
        public long Id { get; set; }
        public long? MediaItemId { get; set; }
        public long? DirectoryId { get; set; }
        public string Hash { get; set; }
        public string OpenSubtitleHash { get; set; }
        public string File { get; set; }
        public long? Index { get; set; }
        public long? Size { get; set; }
        public long? Duration { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string ExtraData { get; set; }
    }
}
