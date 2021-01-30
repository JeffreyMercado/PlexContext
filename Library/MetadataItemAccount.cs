using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Library
{
    public partial class MetadataItemAccount
    {
        public long Id { get; set; }
        public long? AccountId { get; set; }
        public long? MetadataItemId { get; set; }
    }
}
