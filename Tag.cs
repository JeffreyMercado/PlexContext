using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class Tag
    {
        public long Id { get; set; }
        public long? MetadataItemId { get; set; }
        public string Tag1 { get; set; }
        public long? TagType { get; set; }
        public string UserThumbUrl { get; set; }
        public string UserArtUrl { get; set; }
        public string UserMusicUrl { get; set; }
        public byte[] CreatedAt { get; set; }
        public byte[] UpdatedAt { get; set; }
        public long? TagValue { get; set; }
        public string ExtraData { get; set; }
        public string Key { get; set; }
        public long? ParentId { get; set; }
    }
}
