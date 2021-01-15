using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class MediaItem
    {
        public long Id { get; set; }
        public long? LibrarySectionId { get; set; }
        public long? SectionLocationId { get; set; }
        public long? MetadataItemId { get; set; }
        public long? TypeId { get; set; }
        public long? Width { get; set; }
        public long? Height { get; set; }
        public long? Size { get; set; }
        public long? Duration { get; set; }
        public long? Bitrate { get; set; }
        public string Container { get; set; }
        public string VideoCodec { get; set; }
        public string AudioCodec { get; set; }
        public double? DisplayAspectRatio { get; set; }
        public double? FramesPerSecond { get; set; }
        public long? AudioChannels { get; set; }
        public byte[] Interlaced { get; set; }
        public string Source { get; set; }
        public string Hints { get; set; }
        public long? DisplayOffset { get; set; }
        public string Settings { get; set; }
        public byte[] CreatedAt { get; set; }
        public byte[] UpdatedAt { get; set; }
        public byte[] OptimizedForStreaming { get; set; }
        public byte[] DeletedAt { get; set; }
        public long? MediaAnalysisVersion { get; set; }
        public double? SampleAspectRatio { get; set; }
        public string ExtraData { get; set; }
        public long? ProxyType { get; set; }
        public long? ChannelId { get; set; }
        public byte[] BeginsAt { get; set; }
        public byte[] EndsAt { get; set; }
        public string ColorTrc { get; set; }
    }
}
