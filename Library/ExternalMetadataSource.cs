using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Library
{
    public partial class ExternalMetadataSource
    {
        public long Id { get; set; }
        public string Uri { get; set; }
        public string SourceTitle { get; set; }
        public string UserTitle { get; set; }
        public long? Online { get; set; }
    }
}
