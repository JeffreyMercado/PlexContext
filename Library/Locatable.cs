using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Library
{
    public partial class Locatable
    {
        public long Id { get; set; }
        public long LocationId { get; set; }
        public long LocatableId { get; set; }
        public string LocatableType { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string ExtraData { get; set; }
        public long? GeocodingVersion { get; set; }
    }
}
