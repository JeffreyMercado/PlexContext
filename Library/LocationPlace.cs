using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Library
{
    public partial class LocationPlace
    {
        public long Id { get; set; }
        public long? LocationId { get; set; }
        public string Guid { get; set; }
    }
}
