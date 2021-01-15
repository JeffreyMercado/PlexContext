using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class LibrarySection
    {
        public long Id { get; set; }
        public long? LibraryId { get; set; }
        public string Name { get; set; }
        public string NameSort { get; set; }
        public long? SectionType { get; set; }
        public string Language { get; set; }
        public string Agent { get; set; }
        public string Scanner { get; set; }
        public string UserThumbUrl { get; set; }
        public string UserArtUrl { get; set; }
        public string UserThemeMusicUrl { get; set; }
        public byte[] Public { get; set; }
        public byte[] CreatedAt { get; set; }
        public byte[] UpdatedAt { get; set; }
        public byte[] ScannedAt { get; set; }
        public byte[] DisplaySecondaryLevel { get; set; }
        public string UserFields { get; set; }
        public string QueryXml { get; set; }
        public long? QueryType { get; set; }
        public string Uuid { get; set; }
        public long? ChangedAt { get; set; }
        public long? ContentChangedAt { get; set; }
    }
}
