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
        public byte[] CreatedAt { get; set; }
        public byte[] UpdatedAt { get; set; }
        public byte[] DeletedAt { get; set; }
        public string ExtraData { get; set; }
    }
}
