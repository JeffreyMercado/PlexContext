using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class Locatable
    {
        public long Id { get; set; }
        public long LocationId { get; set; }
        public long LocatableId { get; set; }
        public string LocatableType { get; set; }
        public byte[] CreatedAt { get; set; }
        public byte[] UpdatedAt { get; set; }
        public string ExtraData { get; set; }
        public long? GeocodingVersion { get; set; }
    }
}
